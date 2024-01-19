using poc.api.serilog.net8.Model;

namespace poc.api.serilog.net8.Service;

public interface IProdutoService
{
    Task<List<Produto>> Get();
    Task<Produto> Get(int id);
    Task<Produto> Post(Produto entity);
    Task<Produto> Put(Produto entity);
    Task<Produto> Delete(int id);
}
