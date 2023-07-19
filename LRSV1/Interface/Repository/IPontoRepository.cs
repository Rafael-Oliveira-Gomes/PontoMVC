using LRSV1.Models;

namespace LRSV1.Interface.Repository
{
    public interface IPontoRepository
    {
        Task<List<Ponto>> ListDados();
        Task<Ponto> GetPontoById(int IdUser);
        Task<Ponto> GetPontoByUserId(string userId);
        Task<int> UpdatePonto(Ponto user);
        Task<bool> DeletePontoAsync(int Id);
        Task<Ponto> CreatePonto(Ponto ponto);
        Task<Ponto> GetUltimoPontoByUserAndDay(string userId, DateTime dia);
        Task<List<Ponto>> GetPontosByFuncionarioAndMonth(string userId, int month, int year);
    }
}
