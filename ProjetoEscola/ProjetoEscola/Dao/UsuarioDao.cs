using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoEscola.Dao;
using ProjetoEscola.Models;
namespace ProjetoEscola.Dao
{
    public class UsuarioDao
    {
        public Boolean inserir(UsuarioModels model)
        {
            try
            {
                projetoescolaEntities con = new projetoescolaEntities();

                usuario user = new usuario();
                user.username = model.Username;
                user.senha = model.Senha;
                user.cd_nivel = model.CodigoNivelAcesso;
                user.statuss = model.Status;

                con.usuario.Add(user);

                int resultado = con.SaveChanges();

                con.Dispose();

                if(resultado > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               

            }
            catch(Exception ex){ return false;}
        }

        public Boolean deletar(String usuario)
        {
            try
            {
                projetoescolaEntities con = new projetoescolaEntities();

                usuario user = con.usuario.First(p => p.username == usuario);

                if(user != null)
                {
                    con.usuario.Remove(user);

                    int resultado = con.SaveChanges();

                    con.Dispose();

                    if(resultado  > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            catch(Exception ex) { return false; }
        }

        public UsuarioModels entrar(UsuarioModels model)
        {
            UsuarioModels user = new UsuarioModels();

            try
            {
                projetoescolaEntities con = new projetoescolaEntities();

                usuario u = con.usuario.First( p => p.username == model.Username && p.senha == model.Senha);

                if(u != null)
                {
                    user.Username = u.username;
                    user.Senha = u.senha;
                    user.Status = u.statuss.Value;
                    user.CodigoNivelAcesso = u.cd_nivel.Value;
                    user.Valido = true;
                }
                else
                {
                    user.Valido = false;
                }

            }
            catch(Exception ex)
            {
                user.Valido = false;
            }

            return user;
        }

        public List<UsuarioModels> listarTodos()
        {
            
            try
            {

                projetoescolaEntities con = new projetoescolaEntities();

                var dados = con.usuario.Select(p => new UsuarioModels() {
                    Username = p.username,
                    Senha = p.senha,
                    CodigoNivelAcesso = p.cd_nivel.Value,
                    Status = p.statuss.Value,
                    Valido = true    
                }).ToList();

                return dados;
              
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}