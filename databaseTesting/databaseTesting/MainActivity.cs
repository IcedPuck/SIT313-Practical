using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.IO;
using SQLite;

namespace databaseTesting
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        //path
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "dbTest.db3");
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            Button button = FindViewById<Button>(Resource.Id.button1);
            button.Click += delegate
            {
                // setup the db connection
                var db = new SQLiteConnection(dbPath);
                //setup a table
                db.CreateTable<Contact>();
                //create a new contact object
                Contact myContact = new Contact("Sam", "555-555-5555");
                //store the object into the table
                db.Insert(myContact);
            };
            Button getButton = FindViewById<Button>(Resource.Id.get);
            getButton.Click += delegate
            {
                TextView displayText = FindViewById<TextView>(Resource.Id.display);
                //setup the db connection
                var db = new SQLiteConnection(dbPath);
                //Connnect to the table that contains the data we want
                var table = db.Table<Contact>();
                foreach(var item in table)
                {
                    Contact myContact = new Contact(item.Name, item.PhoneNumber);
                    displayText.Text += myContact + "\n";
                }
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}