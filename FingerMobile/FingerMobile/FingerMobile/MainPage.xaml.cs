using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using System.Diagnostics;
using Xamarin.Forms.Xaml;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Data;
using Xamarin.Forms.PlatformConfiguration;
using System.Runtime.CompilerServices;

namespace FingerMobile
{

    [System.Obsolete("deprecated")]
    public partial class MainPage : ContentPage
    {


      

        SqlConnection sqlConnection;

        public MainPage()
        {
            
            InitializeComponent();
            string serverDb = "OtelSEO";
            string serverName = "192.168.2.166";
            string serverUsername = "xamarin";
            string serverPassword = "123456";

            string sqlconn = $"Data Source={serverName};Initial Catalog={serverDb};User ID={serverUsername};Password={serverPassword}";
            sqlConnection = new SqlConnection(sqlconn);


        }
        //meanawol





        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {

           Random rnd = new Random();

           int myNumber;

           myNumber = rnd.Next(1000,9999);


          

            /*try 
            {

                //string serverDb = "OtelSEO";
                //string serverName = "192.168.2.166";
                //string serverUsername = "xamarin";
                //string serverPassword = "123456";

                //string sqlconn = $"Data Source={serverName};Initial Catalog={serverDb}; User Id={serverUsername};Password={serverPassword}";
                //SqlConnection sqlConnection = new SqlConnection(sqlconn);

                // sqlConnection.Open();

                
                


                sqlConnection.Open();

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }*/





            var availability = await 
                CrossFingerprint.Current.IsAvailableAsync();

            if (!availability)


            {

               



                await DisplayAlert("Warning!","","OK" );
             }
            var authResult = await
                CrossFingerprint.Current.AuthenticateAsync(new
                AuthenticationRequestConfiguration("Heads Up", "I would like to use your biometrics, please!"));


            if (authResult.Authenticated )
            {

                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO random(sifre_giris) VALUES(@Number)", sqlConnection))
                {
                    command.Parameters.Add(new SqlParameter("Number", myNumber.ToString()));
                    command.ExecuteNonQuery();
                }
                sqlConnection.Close();




                await DisplayAlert("Yaay!", myNumber.ToString(), "Thanks!");


            }


        }



    }
}
