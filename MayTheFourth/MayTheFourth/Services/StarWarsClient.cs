using MayTheFourth.Entities.Dtos;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using MayTheFourth.Entities;
using System;
using System.Net.Http;
using Microsoft.EntityFrameworkCore;
using MayTheFourth.Data;
using System.Numerics;

namespace MayTheFourth.Services;

public class StarWarsApiClient
{
      private readonly HttpClient _client;
      private readonly Uri _baseAddress;

      public StarWarsApiClient(HttpClient client)
      {
            _client = client;
            _baseAddress = _client.BaseAddress;
      }

      public static HttpClient CreateHttpClient()
      {
            var handler = new HttpClientHandler
            {
                  ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };
            return new HttpClient(handler)
            {
                  BaseAddress = new Uri("https://swapi.py4e.com/api/")
            };
      }

      public async Task SalvarPeopleAsync()
      {
            try
            {
                  for(int i = 1; i <= 88; i++)
                  {
                        Person person = await GetPersonIdAsync(i);

                        if(person == null) continue;

                        Console.WriteLine(person.Nome);
                        // insersão deve ser feita aqui
                  }
                  // savechanges aqui
            }
            catch(HttpRequestException e)
            {
                  Console.WriteLine("\nExceção durante a requisição HTTP:");
                  Console.WriteLine(e.Message);
            }
            catch(JsonException e)
            {
                  Console.WriteLine("\nExceção durante a deserialização do JSON:");
                  Console.WriteLine(e.Message);
            }
      }

      public async Task SalvarPlanetsAsync()
      {
            try
            {
                  for(int i = 1; i <= 61; i++)
                  {
                        Planet planet = await GetPlanetIdAsync(i);

                        if(planet == null) continue;
                        Console.WriteLine(planet.Nome);
                        // insersão deve ser feita aqui
                  }
                  // savechanges aqui
            }
            catch(HttpRequestException e)
            {
                  Console.WriteLine("\nExceção durante a requisição HTTP:");
                  Console.WriteLine(e.Message);
            }
            catch(JsonException e)
            {
                  Console.WriteLine("\nExceção durante a deserialização do JSON:");
                  Console.WriteLine(e.Message);
            }
      }

      public async Task SalvarFilmsAsync()
      {
            try
            {
                  for(int i = 1; i <= 7; i++)
                  {
                        Film film = await GetFilmIdAsync(i);

                        if(film == null) continue;
                        Console.WriteLine(film.Titulo);
                        // insersão deve ser feita aqui
                  }
                  // savechanges aqui
            }
            catch(JsonException e)
            {
                  Console.WriteLine("\nExceção durante a deserialização do JSON:");
                  Console.WriteLine(e.Message);
            }
      }

      public async Task SalvarVehiclesAsync()
      {
            try
            {
                  for(int i = 1; i <= 76; i++)
                  {
                        Vehicle vehicle = await GetVehicleIdAsync(i);

                        if(vehicle == null) continue;
                        Console.WriteLine(vehicle.Nome);
                        // insersão deve ser feita aqui
                  }
                  // savechanges aqui
            }
            catch(HttpRequestException e)
            {
                  Console.WriteLine("\nExceção durante a requisição HTTP:");
                  Console.WriteLine(e.Message);
            }
            catch(JsonException e)
            {
                  Console.WriteLine("\nExceção durante a deserialização do JSON:");
                  Console.WriteLine(e.Message);
            }
      }

      public async Task SalvarStarshipsAsync()
      {
            try
            {
                  for(int i = 1; i <= 77; i++)
                  {
                        Starship starship = await GetStarshipIdAsync(i);

                        if(starship == null) continue;
                        Console.WriteLine(starship.Nome);
                        // insersão deve ser feita aqui
                  }
                  // savechanges aqui
            }
            catch(HttpRequestException e)
            {
                  Console.WriteLine("\nExceção durante a requisição HTTP:");
                  Console.WriteLine(e.Message);
            }
            catch(JsonException e)
            {
                  Console.WriteLine("\nExceção durante a deserialização do JSON:");
                  Console.WriteLine(e.Message);
            }
      }

      public async Task<Person> GetPersonIdAsync(int id)
      {
            try
            {
                  HttpResponseMessage response = await _client.GetAsync($"{_baseAddress}people/{id}");
                  response.EnsureSuccessStatusCode();
                  string responseBody = await response.Content.ReadAsStringAsync();
                  Person person = JsonConvert.DeserializeObject<Person>(responseBody);
                  person.Id = id;

                  return person;
            }
            catch(HttpRequestException)
            {
                  return null;
            }
      }

      public async Task<Planet> GetPlanetIdAsync(int id)
      {
            try
            {
                  HttpResponseMessage response = await _client.GetAsync($"{_baseAddress}planets/{id}");
                  response.EnsureSuccessStatusCode();
                  string responseBody = await response.Content.ReadAsStringAsync();
                  Planet planet = JsonConvert.DeserializeObject<Planet>(responseBody);
                  planet.Id = id;

                  return planet;
            }
            catch(HttpRequestException)
            {
                  return null;
            }
      }

      public async Task<Film> GetFilmIdAsync(int id)
      {
            try
            {
                  HttpResponseMessage response = await _client.GetAsync($"{_baseAddress}films/{id}");
                  response.EnsureSuccessStatusCode();
                  string responseBody = await response.Content.ReadAsStringAsync();
                  Film film = JsonConvert.DeserializeObject<Film>(responseBody);
                  film.Id = id;

                  return film;
            }
            catch(HttpRequestException)
            {
                  return null;
            }
      }

      public async Task<Vehicle> GetVehicleIdAsync(int id)
      {
            try
            {
                  HttpResponseMessage response = await _client.GetAsync($"{_baseAddress}vehicles/{id}");
                  response.EnsureSuccessStatusCode();
                  string responseBody = await response.Content.ReadAsStringAsync();
                  Vehicle vehicle = JsonConvert.DeserializeObject<Vehicle>(responseBody);
                  vehicle.Id = id;

                  return vehicle;
            }
            catch(HttpRequestException)
            {
                  return null;
            }
      }

      public async Task<Starship> GetStarshipIdAsync(int id)
      {
            try
            {
                  HttpResponseMessage response = await _client.GetAsync($"{_baseAddress}starships/{id}");
                  response.EnsureSuccessStatusCode();
                  string responseBody = await response.Content.ReadAsStringAsync();
                  Starship starship = JsonConvert.DeserializeObject<Starship>(responseBody);
                  starship.Id = id;

                  return starship;
            }
            catch(HttpRequestException)
            {
                  return null;
            }
      }

}
public static class Utils
{
      public static int ExtrairValorDaUrl(string url)
      {
            var partes = url.Trim('/').Split('/');
            if(int.TryParse(partes[partes.Length - 1], out int valorInt))
            {
                  return valorInt;
            }
            else
            {
                  throw new ArgumentException("Não foi possível converter o valor para int.");
            }
      }
}