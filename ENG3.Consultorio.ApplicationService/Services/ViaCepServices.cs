using ENG3.Consultorio.ApplicationService.Model;
using ENG3.Consultorio.Doman.ValueObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ENG3.Consultorio.ApplicationService.Services
{
    public class ViaCepServices
    {
        private readonly Uri _baseAddress;

        public ViaCepServices()
        {

            _baseAddress = new Uri("https://viacep.com.br/ws/");
        }
        public Address GetAddress(Address address)
        {
            ViaCepDTO viaCepDto = new ViaCepDTO();
           string cep = FormatCep(address.Cep.ToString());
            if (CepIsValid(cep))
            {
                viaCepDto = sendRequest(cep);
            }
            else
            {
                viaCepDto.Erro = true;
            }
            address.AddressValue = $"{viaCepDto.Logradouro}, {viaCepDto.Bairro}, {viaCepDto.Localidade} - {viaCepDto.Uf}";
            return address;
        }

        private ViaCepDTO sendRequest(string cep)
        {
            ViaCepDTO viaCepDTO = new ViaCepDTO();
            using (var httpClient = new HttpClient { BaseAddress = _baseAddress })
            {
                try
                {
                    var url = _baseAddress + cep + "/json";
                    //  Logger.Log(url);
                    var resp = httpClient.GetAsync(url).Result;


                    if (resp.IsSuccessStatusCode)
                    {

                        string responseJson = resp.Content.ReadAsStringAsync().Result;

                        viaCepDTO = JsonConvert.DeserializeObject<ViaCepDTO>(responseJson);
                    }
                    else
                    {
                        viaCepDTO.Erro = true;
                    }
                }
                catch
                {
                    
                }
            }
            return viaCepDTO;
        }

        private bool CepIsValid(string cep)
        {
            if (String.IsNullOrEmpty(cep))
                return false;
            else if (cep.Length != 8)
                return false;
            return true;
        }

        private string FormatCep(string cep)
        {
            cep = Regex.Replace(cep, @"[^0-9]+", "");
            return cep.PadLeft(8, '0');
        }
    }
}
