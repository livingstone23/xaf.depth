using System;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using XAF.Depth.Module.BusinessObjects;

namespace XAF.Depth.Module.DatabaseUpdate {
    // For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            //string name = "MyName";
            //DomainObject1 theObject = ObjectSpace.FirstOrDefault<DomainObject1>(u => u.Name == name);
            //if(theObject == null) {
            //    theObject = ObjectSpace.CreateObject<DomainObject1>();
            //    theObject.Name = name;
            //}

            //ObjectSpace.CommitChanges(); //Uncomment this line to persist created object(s).

            Contact contactMary = ObjectSpace.FirstOrDefault<Contact>(c => c.FirstName == "Mary" && c.LastName == "Tellitson");
            if (contactMary == null)
            {
                contactMary = ObjectSpace.CreateObject<Contact>();
                contactMary.FirstName = "Mary";
                contactMary.LastName = "Tellitson";
                contactMary.Email = "tellitson@example.com";
                contactMary.Birthday = new DateTime(1980, 11, 27);
            }

            Contact contactAlice = ObjectSpace.FirstOrDefault<Contact>(c => c.FirstName == "Alice" && c.LastName == "Martin");
            if (contactAlice == null)
            {
                contactAlice = ObjectSpace.CreateObject<Contact>();
                contactAlice.FirstName = "Alice";
                contactAlice.LastName = "Martin";
                contactAlice.Email = "ama@example.com";
                contactAlice.Birthday = new DateTime(1976, 05, 18);
            }

            Contact contactAndrew = ObjectSpace.FirstOrDefault<Contact>(c => c.FirstName == "Andrew" && c.LastName == "Fuller");
            if (contactAndrew == null)
            {
                contactAndrew = ObjectSpace.CreateObject<Contact>();
                contactAndrew.FirstName = "Andrew";
                contactAndrew.LastName = "Fuller";
                contactAndrew.Email = "fuller@example.com";
                contactAndrew.Birthday = new DateTime(1952, 03, 19);
            }

            Contact contactJohn= ObjectSpace.FirstOrDefault<Contact>(c => c.FirstName == "John" && c.LastName == "Nilsen");
            if (contactJohn == null)
            {
                contactJohn = ObjectSpace.CreateObject<Contact>();
                contactJohn.FirstName = "John";
                contactJohn.LastName = "Nilsen";
                contactJohn.Email = "john_nilsen@example.com";
                contactJohn.Birthday = new DateTime(1980, 11, 27);
            }

            Contact contactRobert = ObjectSpace.FirstOrDefault<Contact>(c => c.FirstName == "Robert" && c.LastName == "King");
            if (contactRobert == null)
            {
                contactRobert = ObjectSpace.CreateObject<Contact>();
                contactRobert.FirstName = "Robert";
                contactRobert.LastName = "King";
                contactRobert.Email = "king@example.com";
                contactRobert.Birthday = new DateTime(1975, 04, 21);
            }

            ObjectSpace.CommitChanges();

        }
        public override void UpdateDatabaseBeforeUpdateSchema() {
            base.UpdateDatabaseBeforeUpdateSchema();
            //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
            //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
            //}
        }
    }
}
