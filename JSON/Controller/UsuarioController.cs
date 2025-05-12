using JSON.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;


namespace JSON.Controller
{
    public static class UsuarioController
    {
        private static string filePath = "usuarios.json";

        public static List<Usuario> Carregar()
        {
            if (!File.Exists(filePath)) return new List<Usuario>();
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();
        }

        public static void Salvar(List<Usuario> usuarios)
        {
            string json = JsonSerializer.Serialize(usuarios, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static void Adicionar(Usuario novoUsuario)
        {
            var lista = Carregar();
            novoUsuario.ID = lista.Any() ? lista.Max(u => u.ID) + 1 : 0;
            lista.Add(novoUsuario);
            Salvar(lista);
        }

        public static void Atualizar(Usuario usuarioAtualizado)
        {
            var lista = Carregar();
            var index = lista.FindIndex(u => u.ID == usuarioAtualizado.ID);
            if (index >= 0)
            {
                lista[index] = usuarioAtualizado;
                Salvar(lista);
            }
        }

        public static void Excluir(int id)
        {
            var lista = Carregar();
            lista.RemoveAll(u => u.ID == id);
            Salvar(lista);
        }
    }
}
