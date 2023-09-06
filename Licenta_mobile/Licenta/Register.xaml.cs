using Microsoft.Data.SqlClient;
using Microsoft.Maui.ApplicationModel.Communication;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Generic;

namespace Licenta_test;

public partial class Register : ContentPage
{
    private List<Student> Studenti = new List<Student>();
    public Register()
	{
		InitializeComponent();
        
    }


    private async void Button_Clicked_1(object sender, EventArgs e)
    {

        string selected_Facultate = (string)Facultate.SelectedItem;
        string selected_Judet = (string)Judet.SelectedItem;
        string specializare = SpecializareaEntry.Text;
        string selected_an_studiu = (string)AnStudiu.SelectedItem;
        string selected_gen = (string)Gen.SelectedItem;
        string nume = NameEntry.Text;
        string prenume = PrenumeEntry.Text;
        string adresa = AdresaEntry.Text;
        string telefonStudent = TelefonStudentEntry.Text;
        string telefonParinte = TelefonParinteEntry.Text;
        string cNP = CnpEntry.Text;
        string serieCI = SerieCIEntry.Text;
        string numarCI = NrCIEntry.Text;    
        string numeMama = NumeMamaEntry.Text;
        string numeTata = NumeTataEntry.Text;
        string nrMatricol = NrMatricolEntry.Text;
        string nrCamera = NrCameraEntry.Text;

        

        var displayPage = new DisplayPage
        {
            BindingContext = new
            {
                nume,
                prenume,
                selected_gen,
                adresa,
                selected_Judet,
                cNP,
                serieCI,
                numarCI,
                numeMama,
                numeTata,
                telefonStudent,
                telefonParinte,
                nrMatricol,
                nrCamera,
                selected_Facultate,
                specializare,
                selected_an_studiu
            }
        };

        await Navigation.PushAsync(displayPage);

        var stud = new Student

        {
            Nume = nume,
            Prenume= prenume,
            Gen = selected_gen,
            Adresa = adresa,
            Judet = selected_Judet,
            CNP = cNP,
            SerieCI = serieCI,
            NrCI = numarCI,
            NumeMama = numeMama,
            NumeTata = numeTata,
            TelefonStudent = telefonStudent,
            TelefonParinte = telefonParinte,
            NrMatricol = nrMatricol,
            NrCamera = nrCamera,
            Facultatea= selected_Facultate,
            Specializarea= specializare,
            AnStudiu = selected_an_studiu

        };
       
        await DisplayAlert("Success", "Data saved successfully.", "OK");


    }

}