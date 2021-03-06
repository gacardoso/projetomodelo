﻿using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repository;
using ProjetoModelo.Infra.Data.Context;

namespace ProjetoModelo.Infra.Data.Repositories
{
    public class FornecedorRepository : RepositoryBase<Fornecedor, ProjetoModeloContext>, IFornecedorRepository
    {
    }
}
