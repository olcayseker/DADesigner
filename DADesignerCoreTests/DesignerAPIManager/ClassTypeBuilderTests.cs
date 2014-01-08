using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DADesignerCore.DesignerAPIManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DADesignerCore.Entities;
using FluentAssertions;

namespace DADesignerCore.DesignerAPIManager.Tests
{
    [TestClass()]
    public class ClassTypeBuilderTests
    {
        static ClassTypeBuilder builder;
        ClassTypeBuilder localBuilder;
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            builder = new ClassTypeBuilder(new CreateRootClass(), new CreateChildClass(), ManagementPackInitializer.ManagementPack);
        }
        [ClassCleanup]
        public static void Cleanup()
        {
            builder = null;
        }
      
        [TestInitialize]
        public void InitializeTest()
        {
            localBuilder = new ClassTypeBuilder(new CreateRootClass(), new CreateChildClass(), ManagementPackInitializer.ManagementPack);
        }
        [TestMethod()]
        public void BuildRootClassTest()
        {
            ClassType rootClass = new ClassType();
            rootClass.DisplayName = "root";
            rootClass.ID = "root";
            localBuilder.BuildRootClass(rootClass);
        }

        [TestMethod()]
        public void BuildChildClassTest()
        {
            ClassType rootClass = new ClassType();
            rootClass.DisplayName = "root";
            rootClass.ID = "root";
            ClassType childClass = new ClassType();
            childClass.ID = childClass.DisplayName = "child";
            childClass.Parent = rootClass;
            localBuilder.BuildChildClass(childClass);
            
        }

        [TestMethod]
        public void Change_Parent_Element_ID_ShouldChange_All_ID_In_Document()
        {
            ClassType rootClass = new ClassType();
            rootClass.DisplayName = "root";
            rootClass.ID = "root";
            localBuilder.BuildRootClass(rootClass);

            ClassType childClass = new ClassType();
            childClass.ID = childClass.SimpleName = childClass.DisplayName = "child";
            childClass.Parent = rootClass;            
            builder.BuildChildClass(childClass);

            ClassType childClass2 = new ClassType();
            childClass2.ID=childClass2.SimpleName= childClass2.DisplayName = "child";
            childClass2.Parent = childClass;
            builder.BuildChildClass(childClass2);

            //var expected = childClass2.ID + "1";
            childClass2.ID = childClass2.ID + "1";

            var result = ManagementPackInitializer.ManagementPack.Element.Element("TypeDefinitions").Descendants("ClassType")
                 .FirstOrDefault(z => z.Attribute("ID").Value.Contains(childClass2.ID));

            result.Attribute("ID").Value.Should().BeEquivalentTo(childClass2.ID);

            childClass2.ID = childClass2.ID + "2";

        }

        [TestMethod]
        public void Test()
        {
            var result = from ids in ManagementPackInitializer.ManagementPack.Element.Element("TypeDefinitions").Descendants()
                         
                         select ids;
        }
    }
}
