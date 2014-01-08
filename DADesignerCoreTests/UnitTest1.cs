using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DACore.ManagementPackElements;
using DADesignerCore.Entities;

namespace DADesignerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           // ManagementPackElement mpe = new ManagementPackElement("dsds");

            Manifest manifest = new Manifest();

            Identity id = new Identity();
            id.ID = "qwe";
            id.Version = "11";

            manifest.Identity = id;
            manifest.Name = "manifesto";

            Reference ref1 = new Reference() { Alias = "a1", ID = "1", PublicKeyToken = "12312323", Version = "1" };
            Reference ref2 = new Reference() { Alias = "a2", ID = "2", PublicKeyToken = "45666565", Version = "1" };
            manifest.References.Add(ref1);
            manifest.References.Add(ref2);

            var count = manifest.References.Count;

            foreach (var item in manifest.References)
            {
                var x = item;
            }

            var b = manifest.References.Contains(ref1);
            var r = manifest.References.Remove(ref1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            EntityTypes entityTypes = new EntityTypes();

            ClassType c1 = new ClassType() { ID = "1", Base = "abc", Accessibility = "sdasdas", Abstract = true, Hosted = false, Singleton = false };
            ClassType c2 = new ClassType() { ID = "2", Base = "zxcabc", Accessibility = "sdasdas", Abstract = true, Hosted = false, Singleton = false };
            entityTypes.ClassTypes.Add(c1);
            entityTypes.ClassTypes.Add(c2);

            Assert.AreEqual(2, entityTypes.ClassTypes.Count);

            Assert.IsTrue(entityTypes.ClassTypes.Contains(c1));
            entityTypes.ClassTypes.Remove(c1);
            Assert.IsFalse(entityTypes.ClassTypes.Contains(c1));
            Assert.IsTrue(entityTypes.ClassTypes.GetEnumerator().MoveNext());
        }

        [TestMethod]
        public void TestMethod3()
        {
            EntityTypes entityTypes = new EntityTypes();

            RelationshipType r1 = new RelationshipType() { ID = "1", Base = "abc", Accessibility = "sdasdas", Abstract = true, Source = "ass1", Target = "qwe" };
            RelationshipType r2 = new RelationshipType() { ID = "2", Base = "zxcabc", Accessibility = "sdasdas", Abstract = true, Source = "dfgdf", Target = "3545" };
            entityTypes.RelationshipTypes.Add(r1);
            entityTypes.RelationshipTypes.Add(r2);

            Assert.AreEqual(2, entityTypes.RelationshipTypes.Count);

            Assert.IsTrue(entityTypes.RelationshipTypes.Contains(r1));
            entityTypes.RelationshipTypes.Remove(r1);
            Assert.IsFalse(entityTypes.RelationshipTypes.Contains(r1));
            Assert.IsTrue(entityTypes.RelationshipTypes.GetEnumerator().MoveNext());
        }

        [TestMethod]
        public void TestMethod4()
        {
            Monitoring mon = new Monitoring();

            MembershipRule mr1 = new MembershipRule() { MonitoringClass = "m1", RelationshipClass = "rl1" };
            MembershipRule mr2 = new MembershipRule() { MonitoringClass = "m2", RelationshipClass = "rl2" };
            DataSource ds1 = new DataSource() { ID = "ds1", TypeID = "sde23", RuleId = "r1", GroupInstanceId = "g1" };
            ds1.MembershipRules.Add(mr1);
            ds1.MembershipRules.Add(mr2);

            Discovery d1 = new Discovery()
            {
                ID = "1",
                Enabled = true,
                Target = "2qw",
                ConfirmDelivery = false,
                Remotable = false
                ,
                Priority = "wefr",
                Category = "c1"
            };
            d1.DataSource = ds1;
            d1.DiscoveryTypes = new DiscoveryTypes();

            MembershipRule mr3 = new MembershipRule() { MonitoringClass = "m3", RelationshipClass = "rl3" };
            MembershipRule mr4 = new MembershipRule() { MonitoringClass = "m4", RelationshipClass = "rl4" };
            DataSource ds2 = new DataSource() { ID = "ds2", TypeID = "3edc", RuleId = "r2", GroupInstanceId = "g2" };
            ds2.MembershipRules.Add(mr3);
            ds2.MembershipRules.Add(mr4);

            Discovery d2 = new Discovery()
            {
                ID = "2",
                Enabled = true,
                Target = "4rf",
                ConfirmDelivery = false,
                Remotable = false,
                Priority = "şlk",
                Category = "c2"
            };
            d2.DataSource = ds2;
            d2.DiscoveryTypes = new DiscoveryTypes();

            mon.Discoveries.Add(d1);
            mon.Discoveries.Add(d2);

            Assert.AreEqual(2, ds1.MembershipRules.Count);
            Assert.IsTrue(ds1.MembershipRules.Contains(mr1));
            ds1.MembershipRules.Remove(mr1);
            Assert.IsFalse(ds1.MembershipRules.Contains(mr1));
            Assert.IsTrue(ds1.MembershipRules.GetEnumerator().MoveNext());


            Assert.AreEqual(2, mon.Discoveries.Count);
            Assert.IsTrue(mon.Discoveries.Contains(d1));
            mon.Discoveries.Remove(d1);
            Assert.IsFalse(mon.Discoveries.Contains(d1));
            Assert.IsTrue(mon.Discoveries.GetEnumerator().MoveNext());
        }

        [TestMethod]
        public void TestMethod5()
        {
            Monitoring mon = new Monitoring();

            DependencyMonitor dpm1 = new DependencyMonitor()
            {
                ID = "1",
                Accessibility = "2ws",
                Enabled = false,
                Target = "t1",
                ParentMonitorID = "p1",
                Remotable = false,
                Priority = "234r",
                RelationshipType = "rl1",
                MemberMonitor = "mm1",
                Category = "c1",
                Algorithm = "a1"
            };

            DependencyMonitor dpm2 = new DependencyMonitor()
            {
                ID = "2",
                Accessibility = "34wer",
                Enabled = false,
                Target = "t2",
                ParentMonitorID = "p1",
                Remotable = false,
                Priority = "4rfd",
                RelationshipType = "rl1",
                MemberMonitor = "mm2",
                Category = "c2",
                Algorithm = "a1"
            };

            mon.Monitors.Add(dpm1);
            mon.Monitors.Add(dpm2);

            Assert.AreEqual(2, mon.Monitors.Count);
            Assert.IsTrue(mon.Monitors.Contains(dpm1));
            mon.Monitors.Remove(dpm1);
            Assert.IsFalse(mon.Monitors.Contains(dpm1));
            Assert.IsTrue(mon.Monitors.GetEnumerator().MoveNext());
        }

        [TestMethod]
        public void TestMethod6()
        {
            LanguagePacks languagePacks = new LanguagePacks();

            LanguagePack pack = new LanguagePack();
            DisplayString ds1 = new DisplayString() { ElementID = "1", Name = "ds1" };
            DisplayString ds2 = new DisplayString() { ElementID = "2", Name = "ds2" };

            pack.DisplayStrings.Add(ds1);
            pack.DisplayStrings.Add(ds2);

            languagePacks.LanguagePack = pack;

            Assert.AreEqual(2, pack.DisplayStrings.Count);
            Assert.IsTrue(pack.DisplayStrings.Contains(ds1));
            pack.DisplayStrings.Remove(ds1);
            Assert.IsFalse(pack.DisplayStrings.Contains(ds1));
            Assert.IsTrue(pack.DisplayStrings.GetEnumerator().MoveNext());

        }

        [TestMethod]
        public void TestMethod7()
        {
            ManagementPack mp = new ManagementPack();
            mp.Manifest = new Manifest();
            mp.TypeDefinitions = new TypeDefinitions();
            mp.Monitoring = new Monitoring();
            mp.LanguagePacks = new LanguagePacks();

            var x = mp.Element;
        }

        [TestMethod]
        public void TestMethod8()
        {
            ManagementPack mp = new ManagementPack();
            //mp.Manifest = new Manifest();
            //mp.TypeDefinitions = new TypeDefinitions();
            //  mp.Monitoring = new Monitoring();
            //  mp.LanguagePacks = new LanguagePacks();

            Manifest manifest = new Manifest();

            Identity id = new Identity();
            id.ID = "qwe";
            id.Version = "11";

            manifest.Identity = id;
            manifest.Name = "manifesto";

            Reference ref1 = new Reference() { Alias = "a1", ID = "1", PublicKeyToken = "12312323", Version = "1" };
            Reference ref2 = new Reference() { Alias = "a2", ID = "2", PublicKeyToken = "45666565", Version = "1" };
            manifest.References.Add(ref1);
            manifest.References.Add(ref2);

            mp.Manifest = manifest;

            TypeDefinitions typeDefinitions = new TypeDefinitions();

            EntityTypes entityTypes = new EntityTypes();

            ClassType c1 = new ClassType() { ID = "1", Base = "abc", Accessibility = "sdasdas", Abstract = true, Hosted = false, Singleton = false };
            ClassType c2 = new ClassType() { ID = "2", Base = "zxcabc", Accessibility = "sdasdas", Abstract = true, Hosted = false, Singleton = false };
            entityTypes.ClassTypes.Add(c1);
            entityTypes.ClassTypes.Add(c2);

            RelationshipType r1 = new RelationshipType() { ID = "1", Base = "abc", Accessibility = "sdasdas", Abstract = true, Source = "ass1", Target = "qwe" };
            RelationshipType r2 = new RelationshipType() { ID = "2", Base = "zxcabc", Accessibility = "sdasdas", Abstract = true, Source = "dfgdf", Target = "3545" };
            entityTypes.RelationshipTypes.Add(r1);
            entityTypes.RelationshipTypes.Add(r2);

            typeDefinitions.EntityTypes = entityTypes;

            mp.TypeDefinitions = typeDefinitions;

            Monitoring mon = new Monitoring();

            MembershipRule mr1 = new MembershipRule() { MonitoringClass = "m1", RelationshipClass = "rl1" };
            MembershipRule mr2 = new MembershipRule() { MonitoringClass = "m2", RelationshipClass = "rl2" };
            DataSource dataSource1 = new DataSource() { ID = "ds1", TypeID = "sde23", RuleId = "r1", GroupInstanceId = "g1" };
            dataSource1.MembershipRules.Add(mr1);
            dataSource1.MembershipRules.Add(mr2);

            Discovery d1 = new Discovery()
            {
                ID = "1",
                Enabled = true,
                Target = "2qw",
                ConfirmDelivery = false,
                Remotable = false,
                Priority = "wefr",
                Category = "c1"
            };
            d1.DataSource = dataSource1;
            d1.DiscoveryTypes = new DiscoveryTypes();

            MembershipRule mr3 = new MembershipRule() { MonitoringClass = "m3", RelationshipClass = "rl3" };
            MembershipRule mr4 = new MembershipRule() { MonitoringClass = "m4", RelationshipClass = "rl4" };
            DataSource dataSource2 = new DataSource() { ID = "ds2", TypeID = "3edc", RuleId = "r2", GroupInstanceId = "g2" };
            dataSource2.MembershipRules.Add(mr3);
            dataSource2.MembershipRules.Add(mr4);

            Discovery d2 = new Discovery()
            {
                ID = "2",
                Enabled = true,
                Target = "4rf",
                ConfirmDelivery = false,
                Remotable = false,
                Priority = "şlk",
                Category = "c2"
            };
            d2.DataSource = dataSource2;
            d2.DiscoveryTypes = new DiscoveryTypes();

            mon.Discoveries.Add(d1);
            mon.Discoveries.Add(d2);

            DependencyMonitor dpm1 = new DependencyMonitor()
            {
                ID = "1",
                Accessibility = "2ws",
                Enabled = false,
                Target = "t1",
                ParentMonitorID = "p1",
                Remotable = false,
                Priority = "234r",
                RelationshipType = "rl1",
                MemberMonitor = "mm1",
                Category = "c1",
                Algorithm = "a1"
            };

            DependencyMonitor dpm2 = new DependencyMonitor()
            {
                ID = "2",
                Accessibility = "34wer",
                Enabled = false,
                Target = "t2",
                ParentMonitorID = "p1",
                Remotable = false,
                Priority = "4rfd",
                RelationshipType = "rl1",
                MemberMonitor = "mm2",
                Category = "c2",
                Algorithm = "a1"
            };

            mon.Monitors.Add(dpm1);
            mon.Monitors.Add(dpm2);

            mp.Monitoring = mon;

            LanguagePacks languagePacks = new LanguagePacks();

            LanguagePack pack = new LanguagePack();
            DisplayString ds1 = new DisplayString() { ElementID = "1", Name = "ds1" };
            DisplayString ds2 = new DisplayString() { ElementID = "2", Name = "ds2" };

            pack.DisplayStrings.Add(ds1);
            pack.DisplayStrings.Add(ds2);

            languagePacks.LanguagePack = pack;

            mp.LanguagePacks = languagePacks;


            var x = mp.Element;
        }

        [TestMethod]
        public void TestMethod9()
        {
            //initialize first model

            ManagementPack mp = new ManagementPack();

            mp.Manifest = new Manifest();

            Identity id = new Identity();
            id.ID = "daDesigner";
            id.Version = "1.0.0.4";

            mp.Manifest.Identity = id;
            mp.Manifest.Name = "daDesigner";

            mp.TypeDefinitions = new TypeDefinitions();

            mp.TypeDefinitions.EntityTypes = new EntityTypes();

            mp.Monitoring = new Monitoring();

            mp.LanguagePacks = new LanguagePacks();

            mp.LanguagePacks.LanguagePack = new LanguagePack();



            var x = mp.Element;
        }
    }
}
