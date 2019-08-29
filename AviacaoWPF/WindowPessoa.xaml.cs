using Aviacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AviacaoWPF
{
    /// <summary>
    /// Lógica interna para WindowPessoa.xaml
    /// </summary>
    public partial class WindowPessoa : Window
    {
        public ViewModel.PessoasViewModel PessoasViewModel { get; set; }
        public WindowPessoa()
        {
            InitializeComponent();
            this.PessoasViewModel = new ViewModel.PessoasViewModel();
            this.DataContext = this;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.PessoasViewModel.Salvar();
            this.Close();
        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            PessoasViewModel.Adicionar();
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            PessoasViewModel.Remover();
        }

        private void ListView_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
