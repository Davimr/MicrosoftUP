using Aviacao;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviacaoWPF.ViewModel
{
    public class PessoasViewModel
    {

        public ObservableCollection<Pessoa> Pessoas { get; set; }

        public Boolean PodeRemover
        {
            get
            {
                return this.PessoaSelecionada != null;
            }
        }

        public Pessoa PessoaSelecionada { get; set; }

        public ModelAviacao modelAviacao = new ModelAviacao();

        public PessoasViewModel()
        {
            this.Pessoas = new ObservableCollection<Pessoa>(modelAviacao.Pessoas.ToList());
            this.PessoaSelecionada = modelAviacao.Pessoas.FirstOrDefault();
        }

        public void Salvar()
        {
            this.modelAviacao.SaveChanges();
        }

        public void Remover()
        {
            if (this.PessoaSelecionada.Id != 0)
            {
                this.Pessoas.Remove(PessoaSelecionada);
                this.modelAviacao.Pessoas.Remove(PessoaSelecionada);
            }
        }

        public void Adicionar()
        {
            Pessoa p = new Pessoa();
            this.Pessoas.Add(p);
            this.PessoaSelecionada = p;
            this.modelAviacao.Pessoas.Add(p);
        }
    }
}
