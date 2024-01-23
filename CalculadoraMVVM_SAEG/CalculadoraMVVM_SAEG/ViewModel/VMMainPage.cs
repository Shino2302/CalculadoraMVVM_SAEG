using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CalculadoraMVVM_SAEG.ViewModel
{
    public class VMMainPage : BaseViewModel
    {
        #region VARIABLES
        string _resultado = "";
        bool _labelSecundario = false;
        string _procedimiento;
        int _posicionLabelProcedimiento = 1;
        int _posicionLabelResultado = 0;
        #endregion

        #region CONSTRUCTOR
        #endregion
        public VMMainPage(INavigation navigation)
        {
            Navigation = navigation;
            ActivarDescativarLabel();
        }
        #region OBJETOS
        #endregion
        public string Resultado
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }
        public bool LabelSecundario
        {
            get { return _labelSecundario;}
            set { SetValue(ref _labelSecundario, value); }
        }
        public string Procedimiento
        {
            get {return _procedimiento; }
            set { SetValue(ref _procedimiento, value);}
        }
        public int PosicionLabelProcedimiento
        {
            get { return _posicionLabelProcedimiento; }
            set { SetValue(ref _posicionLabelProcedimiento, value); }
        }
        public int PosicionLabelResultado
        {
            get { return _posicionLabelResultado; }
            set { SetValue(ref _posicionLabelResultado, value); }
        }
        #region PROCESOS
        public void SacarResultado()
        {
            double cuenta = 0;
            if (_procedimiento!= "")
            {
                cuenta = double.Parse(_procedimiento);
                _procedimiento = cuenta.ToString();
                _resultado = "";
                _labelSecundario = false;
            }
        }
        public void ActivarDescativarLabel()
        {
            if(_procedimiento != "")
            {
                _posicionLabelProcedimiento = 0;
                _posicionLabelResultado = 1;
                _labelSecundario = true;
            }
            else
            {
                _labelSecundario = false;
                _posicionLabelProcedimiento = 1;
            }
        }
        public void DectectarSignos()
        {
            if (_procedimiento.Contains("+-/x"))
            {

            }
            else if (_procedimiento.Contains("."))
            {

            }
        }
        public void BorrarTodo()
        {
            _resultado = "";
            _procedimiento = "";
        }
        public void BorrarUltimoCaracter()
        {
            _procedimiento = _procedimiento.Substring(0, _procedimiento.Length - 1);
        }
        #endregion
        #region COMANDOS
        public ICommand SacarResultadoCommand => new Command(SacarResultado);
        public ICommand BorrarTodoCommand => new Command(BorrarTodo);
        public ICommand BorrarUltimoCaracterCommand => new Command(BorrarUltimoCaracter);
        #endregion
    }
}
