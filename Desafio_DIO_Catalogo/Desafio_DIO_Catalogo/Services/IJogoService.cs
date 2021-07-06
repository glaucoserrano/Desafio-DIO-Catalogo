using Desafio_DIO_Catalogo.InputModel;
using Desafio_DIO_Catalogo.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio_DIO_Catalogo.Services
{
    public interface IJogoService : IDisposable
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}
