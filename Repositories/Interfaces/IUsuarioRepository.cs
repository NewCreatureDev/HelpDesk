﻿using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario SelecionarFiltrado(int id);
        IList<Usuario> Selecionar();
    }
}
