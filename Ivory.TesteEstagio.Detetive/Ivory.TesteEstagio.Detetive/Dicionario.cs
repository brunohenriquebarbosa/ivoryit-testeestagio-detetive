using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivory.TesteEstagio.Detetive
{
    class Dicionario
    {
        /// <summary>
        /// Função utilizada para buscar o nome do criminoso.
        /// </summary>
        public string BuscaCriminoso(int criminoso)
        {
            if (criminoso == 1)
            {
                return "Advogado Sr. Marinho";
            }
            else if (criminoso == 2)
            {
                return "Chef. de Cozinha Tony Gourmet";
            }
            else if (criminoso == 3)
            {
                return "Coveiro Sérgio Sortuno";
            }
            else if (criminoso == 4)
            {
                return "Dançarina Srta. Rosa";
            }
            else if (criminoso == 5)
            {
                return "Florista Dona Branca";
            }
            else if (criminoso == 6)
            {
                return "Médica Dona Violeta";
            }
            else if (criminoso == 7)
            {
                return "Mordomo James";
            }
            else if (criminoso == 8)
            {
                return "Sargento Bigode";
            }
            return "Nome do criminoso não identificado";
        }

        /// <summary>
        /// Função utilizada para buscar a descrição do local do crime.
        /// </summary>
        public string BuscaLocal(int local)
        {
            if (local == 1)
            {
                return "Biblioteca";
            }
            else if (local == 2)
            {
                return "Cozinha";
            }
            else if (local == 3)
            {
                return "Hall";
            }
            else if (local == 4)
            {
                return "Escritório";
            }
            else if (local == 5)
            {
                return "Sala de estar";
            }
            else if (local == 6)
            {
                return "Sala de jantar";
            }
            else if (local == 7)
            {
                return "Sala de música";
            }
            else if (local == 8)
            {
                return "Salão de festas";
            }
            else if (local == 9)
            {
                return "Salão de jogos";
            }
            return "Nome do local não identificado";
        }

        /// <summary>
        /// Função utilizada para buscar o tipo de arma utilizada no crime.
        /// </summary>
        public string BuscaArma(int arma)
        {
            if (arma == 1)
            {
                return "Castiçal";
            }
            else if (arma == 2)
            {
                return "Cano";
            }
            else if (arma == 3)
            {
                return "Chave inglesa";
            }
            else if (arma == 4)
            {
                return "Corda";
            }
            else if (arma == 5)
            {
                return "Revólver";
            }
            else if (arma == 6)
            {
                return "Faca";
            }
            return "Tipo da arma não identificado";
        }
    }
}
