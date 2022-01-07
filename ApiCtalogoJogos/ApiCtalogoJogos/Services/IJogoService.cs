using ApiCtalogoJogos.ViewModel;
using ApiCtalogoJogos.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCtalogoJogos.Services
{
    public interface IJogoService : IDisposable
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid guid);
        Task<JogoViewModel> Inserir(JogoInputmodel jogo);
        Task Atualizar(Guid id, JogoInputmodel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid guid);

    }
}
