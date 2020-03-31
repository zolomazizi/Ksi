using ShellAppSample.Services;
using ShellAppSample.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShellAppSample.ViewModels
{
    public class PickerRepViewModel : INotifyPropertyChanged
    {
        ApiService apiService = new ApiService();
        // Model for POST Method to Backend
        public List<Reponse> Results { get; set; }
        // Instantiate a List of Model For each Picker 
        public List<Reponse> rep { get; set; }
        public List<Reponse> rep1 { get; set; }
        public List<Reponse> rep2 { get; set; }
        public List<Reponse> rep3 { get; set; }
        public List<Reponse> rep4 { get; set; }
        public List<Reponse> rep5 { get; set; }
        public List<Reponse> rep6 { get; set; }
        public List<Reponse> rep7 { get; set; }
        public List<Reponse> rep8 { get; set; }
        public List<Reponse> rep9 { get; set; }


        public PickerRepViewModel()
        {
            // All Request To retrieve Data from model 
            rep = GetRep().OrderBy(t => t.Rep).ToList();
            rep1 = GetRep1().OrderBy(t => t.Rep).ToList();
            rep2 = GetRep2().OrderBy(t => t.Rep).ToList();
            rep3 = GetRep3().OrderBy(t => t.Rep).ToList();
            rep4 = GetRep4().OrderBy(t => t.Rep).ToList();
            rep5 = GetRep5().OrderBy(t => t.Rep).ToList();
            rep6 = GetRep6().OrderBy(t => t.Rep).ToList();
            rep7 = GetRep7().OrderBy(t => t.Rep).ToList();
            rep8 = GetRep8().OrderBy(t => t.Rep).ToList();
            rep9 = GetRep9().OrderBy(t => t.Rep).ToList();

        }

        // Method to handle property when it will change ( Hade ta declanche l'evenement fache taytbedel  choix f picker)
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]
                                                string propertyName =null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #region Answers Q1 Picker Logic 
        // Proerty to store changed value in picker 
        private string _myRep;
        public string MyRep
        {
            get { return _myRep; }
            set
            {
                if (_myRep != value)
                {
                    _myRep = value;
                    OnPropertyChanged();
                }
            }
        }

        // Do whatever functionality you want...When a selectedItem is changed.. 
        private Reponse _selectedRep { get; set; }
        public Reponse SelectedRep
        {
            get { return _selectedRep; }
            set
            {
                if (_selectedRep != value)
                {
                    _selectedRep = value;
                    // write code here..
                    MyRep = "Reponse : " + _selectedRep.Id;

                }
            }
        }
        // Answers Value and Id 
        public List<Reponse> GetRep()
        {
            var reps = new List<Reponse>()
            {
                new Reponse(){Id = 3,Rep="1- Oui ; Je reviens de Voyage d’une Zone à Risque. ",QstN="A"},
                new Reponse(){Id = 1,Rep="2- Non ; Je ne me suis pas déplacé dans une Zone à Risque durant les 15 derniers jours. ",QstN="A"},
                new Reponse(){Id = 2,Rep="3- Je ne peux pas qualifier les Zones dans lesquelles je me suis déplacé les 15 derniers jours",QstN="A"}

            };
            return reps;
        }
        #endregion


        #region Answers Q2 Picker Logic 
        private string _myRep1;
        public string MyRep1
        {
            get { return _myRep1; }
            set
            {
                if (_myRep1 != value)
                {
                    _myRep1 = value;
                    OnPropertyChanged();
                }
            }
        }
        private Reponse _selectedRep1 { get; set; }
        public Reponse SelectedRep1
        {
            get { return _selectedRep1; }
            set
            {
                if (_selectedRep1 != value)
                {
                    _selectedRep1 = value;
                    // Do whatever functionality you want...When a selectedItem is changed..
                    // write code here..
                    MyRep1 = "Reponse : " + _selectedRep1.Id;
                }
            }
        }
        public List<Reponse> GetRep1()
        {
            var reps1 = new List<Reponse>()
            {
                new Reponse(){Id = 3,Rep="1- Oui, J’ai été en contact avec une personne « malade confirmée » durant les 15 derniers jours. ",QstN="B"},
                new Reponse(){Id = 1,Rep="2- Non, je n’ai pas été en en contact avec une personne « malade avérée » durant les 15 derniers jours. ",QstN="B"},
                new Reponse(){Id = 2,Rep="3- Je ne peux pas répondre à une telle question. ",QstN="B"}

            };
            return reps1;
        }
        #endregion




        #region Answers Q3 Picker Logic 
        private string _myRep2;
        public string MyRep2
        {
            get { return _myRep2; }
            set
            {
                if (_myRep2 != value)
                {
                    _myRep2 = value;
                    OnPropertyChanged();
                }
            }
        }
        private Reponse _selectedRep2 { get; set; }
        public Reponse SelectedRep2
        {
            get { return _selectedRep2; }
            set
            {
                if (_selectedRep2 != value)
                {
                    _selectedRep2 = value;
                    // Do whatever functionality you want...When a selectedItem is changed..
                    // write code here..
                    MyRep2 = "Reponse : " + _selectedRep2.Id;
                }
            }
        }
        public List<Reponse> GetRep2()
        {
            var reps2 = new List<Reponse>()
            {
                new Reponse(){Id = 3,Rep="1- Oui, ma Toux est SECHE. ",QstN="C"},
                new Reponse(){Id = 2,Rep="2- Oui ; ma Toux est GRASSE. ",QstN="C"},
                new Reponse(){Id = 1,Rep="3- Non, Je ne tousse pas. ",QstN="C"}

            };
            return reps2;
        }
        #endregion


        #region Answers Q4 Picker Logic 
        private string _myRep3;
        public string MyRep3
        {
            get { return _myRep3; }
            set
            {
                if (_myRep3 != value)
                {
                    _myRep3 = value;
                    OnPropertyChanged();
                }
            }
        }
        private Reponse _selectedRep3 { get; set; }
        public Reponse SelectedRep3
        {
            get { return _selectedRep3; }
            set
            {
                if (_selectedRep3 != value)
                {
                    _selectedRep3 = value;
                    // Do whatever functionality you want...When a selectedItem is changed..
                    // write code here..
                    MyRep3 = "Reponse : " + _selectedRep3.Id;
                }
            }
        }
        public List<Reponse> GetRep3()
        {
            var reps3 = new List<Reponse>()
            {
                new Reponse(){Id = 3,Rep="1- Oui,  Ma Fièvre est Supérieure à 38,5° Celsius depuis 5 Jours .",QstN="D"},
                new Reponse(){Id = 3,Rep="2- Oui,  Ma Fièvre est Supérieure à 38,5° Celsius depuis 2 Jours. ",QstN="D"},
                new Reponse(){Id = 1,Rep="3- Oui, Ma Fièvre est Inférieure à 38,5° Celsius. ",QstN="D"} ,
                 new Reponse(){Id = 2,Rep="4- Non, ma Température est NORMALE, 37° Celsius. ",QstN="D"} ,
                  new Reponse(){Id = 2,Rep="5- Je n’ai pas le moyen de le contrôler. ",QstN="D"}

            };
            return reps3;
        }
        #endregion

        #region Answers Q5 Picker Logic 
        private string _myRep4;
        public string MyRep4
        {
            get { return _myRep4; }
            set
            {
                if (_myRep4 != value)
                {
                    _myRep4 = value;
                    OnPropertyChanged();
                }
            }
        }
        private Reponse _selectedRep4 { get; set; }
        public Reponse SelectedRep4
        {
            get { return _selectedRep4; }
            set
            {
                if (_selectedRep4 != value)
                {
                    _selectedRep4 = value;
                    // Do whatever functionality you want...When a selectedItem is changed..
                    // write code here..
                    MyRep4 = "Reponse : " + _selectedRep4.Id;
                }
            }
        }
        public List<Reponse> GetRep4()
        {
            var reps4 = new List<Reponse>()
            {
                new Reponse(){Id = 3,Rep="1- Oui, je souffre de mal de tête ou de migraine. ",QstN="E"},
                new Reponse(){Id = 1,Rep="2- Non , Je ne souffre pas de mal de tête ou de migraine. ",QstN="E"},


            };
            return reps4;
        }
        #endregion



        #region Answers Q6 Picker Logic 
        private string _myRep5;
        public string MyRep5
        {
            get { return _myRep5; }
            set
            {
                if (_myRep5 != value)
                {
                    _myRep5 = value;
                    OnPropertyChanged();
                }
            }
        }
        private Reponse _selectedRep5 { get; set; }
        public Reponse SelectedRep5
        {
            get { return _selectedRep5; }
            set
            {
                if (_selectedRep5 != value)
                {
                    _selectedRep5 = value;
                    // Do whatever functionality you want...When a selectedItem is changed..
                    // write code here..
                    MyRep5 = "Reponse : " + _selectedRep5.Id;
                }
            }
        }
        public List<Reponse> GetRep5()
        {
            var reps5 = new List<Reponse>()
            {
                new Reponse(){Id = 3,Rep="1- Oui, je souffre de diarrhée ou de vomissement ACTUELLEMENT. ",QstN="F"},
                new Reponse(){Id = 2,Rep="2- Oui, je souffrais de diarrhée ou de vomissement LES DEUX DERNIERS JOURS. ",QstN="F"},
                new Reponse(){Id = 1,Rep="3- Non, je ne souffre pas de diarrhée. ",QstN="F"}

            };
            return reps5;
        }
        #endregion


        #region Answers Q7 Picker Logic 
        private string _myRep6;
        public string MyRep6
        {
            get { return _myRep6; }
            set
            {
                if (_myRep6 != value)
                {
                    _myRep6 = value;
                    OnPropertyChanged();
                }
            }
        }
        private Reponse _selectedRep6 { get; set; }
        public Reponse SelectedRep6
        {
            get { return _selectedRep6; }
            set
            {
                if (_selectedRep6 != value)
                {
                    _selectedRep6 = value;
                    // Do whatever functionality you want...When a selectedItem is changed..
                    // write code here..
                    MyRep6 = "Reponse : " + _selectedRep6.Id;
                }
            }
        }
        public List<Reponse> GetRep6()
        {
            var reps6 = new List<Reponse>()
            {
                new Reponse(){Id = 3,Rep="1- Oui, Je souffre de maladies Chroniques et /ou de co morbidités (Ex : Diabète, hypertension, Maladies cardio-vasculaires). ",QstN="J"},
                new Reponse(){Id = 1,Rep="2- Non, je ne souffre pas de maladies chroniques et ne présente pas de co morbidités. ",QstN="J"},
                new Reponse(){Id = 1,Rep="3- Je ne peux pas répondre à cette question. ",QstN="J"}

            };
            return reps6;
        }
        #endregion


        #region Answers Q8 Picker Logic 
        private string _myRep7;
        public string MyRep7
        {
            get { return _myRep7; }
            set
            {
                if (_myRep7 != value)
                {
                    _myRep7 = value;
                    OnPropertyChanged();
                }
            }
        }
        private Reponse _selectedRep7 { get; set; }
        public Reponse SelectedRep7
        {
            get { return _selectedRep7; }
            set
            {
                if (_selectedRep7 != value)
                {
                    _selectedRep7 = value;
                    // Do whatever functionality you want...When a selectedItem is changed..
                    // write code here..
                    MyRep7 = "Reponse : " + _selectedRep7.Id;
                }
            }
        }
        public List<Reponse> GetRep7()
        {
            var reps7 = new List<Reponse>()
            {
                new Reponse(){Id = 3,Rep="1- Oui, je prends des Antibiotiques ou des Anti-inflammatoires .",QstN="H"},
                new Reponse(){Id = 2,Rep="2- Oui, je prends des médicaments, mais je ne sais pas les qualifier .",QstN="H"},
                new Reponse(){Id = 1,Rep="3- Non, je ne prends pas de médicaments . ",QstN="H"}

            };
            return reps7;
        }
        #endregion

        #region Answers Q9 Picker Logic 

        private string _myRep8;
        public string MyRep8
        {
            get { return _myRep8; }
            set
            {
                if (_myRep8 != value)
                {
                    _myRep8 = value;
                    OnPropertyChanged();
                }
            }
        }
        private Reponse _selectedRep8 { get; set; }
        public Reponse SelectedRep8
        {
            get { return _selectedRep8; }
            set
            {
                if (_selectedRep8 != value)
                {
                    _selectedRep8 = value;
                    // Do whatever functionality you want...When a selectedItem is changed..
                    // write code here..
                    MyRep8 = "Reponse : " + _selectedRep8.Id;
                }
            }
        }
        public List<Reponse> GetRep8()
        {
            var reps8 = new List<Reponse>()
            {
                new Reponse(){Id = 3,Rep="1- Oui, je souffre d’une conjonctivite .",QstN="I"},
                new Reponse(){Id = 1,Rep="2- Non, je ne souffre pas de conjonctivite .",QstN="I"},


            };
            return reps8;
        }
        #endregion


        #region Answers Q10 Picker Logic 

        private string _myRep9;
        public string MyRep9
        {
            get { return _myRep9; }
            set
            {
                if (_myRep9 != value)
                {
                    _myRep9 = value;
                    OnPropertyChanged();
                }
            }
        }
        private Reponse _selectedRep9 { get; set; }
        public Reponse SelectedRep9
        {
            get { return _selectedRep9; }
            set
            {
                if (_selectedRep9 != value)
                {
                    _selectedRep9 = value;
                    // Do whatever functionality you want...When a selectedItem is changed..
                    // write code here..
                    MyRep9 = "Reponse : " + _selectedRep9.Id;
                }
            }
        }
        public List<Reponse> GetRep9()
        {
            var reps9 = new List<Reponse>()
            {
                new Reponse(){Id = 3,Rep="1- Oui, je souffre d’une conjonctivite .",QstN="G"},
                new Reponse(){Id = 1,Rep="2- Non, je ne souffre pas de conjonctivite .",QstN="G"},


            };
            return reps9;
        }
        #endregion


        public List<Reponse> GetReponses()
        {
            Results = new List<Reponse>();
            Results.Add(_selectedRep);
            Results.Add(_selectedRep1);
            Results.Add(_selectedRep2);
            Results.Add(_selectedRep3);
            Results.Add(_selectedRep4);
            Results.Add(_selectedRep5);
            Results.Add(_selectedRep6);
            Results.Add(_selectedRep7);
            Results.Add(_selectedRep8);
            Results.Add(_selectedRep9);

            return Results;
        }
        public ICommand PostCommand
        {
            get
            {
                return new Command(async () =>
                {
                    responses rs = new responses();
                    rs.A = _selectedRep.Id;
                    rs.B = _selectedRep1.Id;
                    rs.C = _selectedRep2.Id;
                    rs.D = _selectedRep3.Id;
                    rs.E = _selectedRep4.Id;
                    rs.F = _selectedRep5.Id;
                    rs.J = _selectedRep6.Id;
                    rs.H = _selectedRep7.Id;
                    rs.I = _selectedRep8.Id;
                    rs.G = _selectedRep9.Id;

                    await apiService.PostRepAsync(rs,"234321", ShellAppSample.Helpers.Settings.AccessToken);
                   
                });
            }
        }

        
    }
    public class Reponse
    {
        public int Id { get; set; }
        public string Rep { get; set; }
        public string QstN { get; set; }
    }
    public class responses
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int E { get; set; }
        public int F { get; set; }
        public int J { get; set; }
        public int H { get; set; }
        public int I { get; set; }
        public int G { get; set; }

    }
}
