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
    public class CreateRootClassTests
    {
        [TestMethod()]
        public void CreateRootClassTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateClassTest()
        {
            ClassType rootClass = new ClassType();
            rootClass.DisplayName = "root";
            rootClass.ID = "root";

            rootClass.Element.ToString().Should().BeEquivalentTo("<ClassType ID=\"root\" Accessibility=\"Public\" Base=\"\" Abstract=\"false\" Hosted=\"false\" Singleton=\"false\" />");
        }

        [TestMethod()]
        public void CreateDisplayStringTest()
        {
            DisplayString displayString = new DisplayString() { Name = "root" };
            displayString.Element.ToString().Should().BeEquivalentTo("<DisplayString ElementID=\"\">\r\n  <Name>root</Name>\r\n  <Description />\r\n</DisplayString>");
        }

        [TestMethod]
        public void Changing_Property_Value_Should_Change_Element_Value()
        {
            ClassType rootClass = new ClassType();
            rootClass.DisplayName = "root";
            rootClass.ID = "root";

            var expected = "root1";
            rootClass.ID = rootClass.ID + "1";
            rootClass.ID.Should().BeEquivalentTo(expected);
            rootClass.Element.Attribute("ID").Value.Should().BeEquivalentTo(expected);
        }
    }
}
