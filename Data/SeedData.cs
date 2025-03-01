using System;
using Microsoft.EntityFrameworkCore;
using MvcDB.Web.Models;

namespace MvcDB.Web.Data;

public static class SeedData {
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Team>().HasData(
            GetTeams()
        );
        modelBuilder.Entity<Player>().HasData(
            GetPlayers()
        );
    }
    public static List<Team> GetTeams() {
        List<Team> teams = new List<Team>() {
            new Team() {    // 1
                TeamName="Canucks",
                City="Vancouver",
                Province="BC",
                Country="Canada",
            },
            new Team() {    //2
                TeamName="Sharks",
                City="San Jose",
                Province="CA",
                Country="USA",
            },
            new Team() {    // 3
                TeamName="Oilers",
                City="Edmonton",
                Province="AB",
                Country="Canada",
            },
            new Team() {    // 4
                TeamName="Flames",
                City="Calgary",
                Province="AB",
                Country="Canada",
            },
            new Team() {    // 5
                TeamName="Leafs",
                City="Toronto",
                Province="ON",
                Country="Canada",
            },
            new Team() {    // 6
                TeamName="Ducks",
                City="Anaheim",
                Province="CA",
                Country="USA",
            },
            new Team() {    // 7
                TeamName="Lightening",
                City="Tampa Bay",
                Province="FL",
                Country="USA",
            },
            new Team() {    // 8
                TeamName="Blackhawks",
                City="Chicago",
                Province="IL",
                Country="USA",
            },
        };

        return teams;
    }
    public static List<Player> GetPlayers() {
        List<Player> players = new List<Player>() {
            new Player {
                PlayerId = 1,
                JerseyNumber = 47,
                FirstName = "Sven",
                LastName = "Baertschi",
                TeamName = "Canucks",
                Position = "Forward"
            },
            new Player {
                PlayerId = 2,
                JerseyNumber = 33,
                FirstName = "Hendrik",
                LastName = "Sedin",
                TeamName = "Canucks",
                Position = "Left Wing"
            },
            new Player {
                PlayerId = 3,
                JerseyNumber = 12,
                FirstName = "John",
                LastName = "Rooster",
                TeamName = "Flames",
                Position = "Right Wing"
            },
            new Player {
                PlayerId = 4,
                JerseyNumber = 44,
                FirstName = "Bob",
                LastName = "Plumber",
                TeamName = "Oilers",
                Position = "Defense"
            },
            new Player {
                PlayerId = 5,
                JerseyNumber = 97,
                FirstName = "Connor",
                LastName = "McDavid",
                TeamName = "Oilers",
                Position = "Center"
            },
            new Player {
                PlayerId = 6,
                JerseyNumber = 29,
                FirstName = "Nathan",
                LastName = "MacKinnon",
                TeamName = "Sharks",
                Position = "Center"
            },
            new Player {
                PlayerId = 7,
                JerseyNumber = 8,
                FirstName = "Alex",
                LastName = "Ovechkin",
                TeamName = "Lightening",
                Position = "Left Wing"
            },
            new Player {
                PlayerId = 8,
                JerseyNumber = 87,
                FirstName = "Sidney",
                LastName = "Crosby",
                TeamName = "Ducks",
                Position = "Center"
            },
            new Player {
                PlayerId = 9,
                JerseyNumber = 88,
                FirstName = "Patrick",
                LastName = "Kane",
                TeamName = "Blackhawks",
                Position = "Right Wing"
            },
            new Player {
                PlayerId = 10,
                JerseyNumber = 34,
                FirstName = "Auston",
                LastName = "Matthews",
                TeamName = "Leafs",
                Position = "Center"
            },
            new Player {
                PlayerId = 11,
                JerseyNumber = 91,
                FirstName = "Steven",
                LastName = "Stamkos",
                TeamName = "Leafs",
                Position = "Center"
            },
            new Player {
                PlayerId = 12,
                JerseyNumber = 11,
                FirstName = "Carey",
                LastName = "Price",
                TeamName = "Flames",
                Position = "Goaltender"
            },
            new Player {
                PlayerId = 13,
                JerseyNumber = 77,
                FirstName = "Victor",
                LastName = "Hedman",
                TeamName = "Oilers",
                Position = "Defense"
            },
            new Player {
                PlayerId = 14,
                JerseyNumber = 13,
                FirstName = "Johnny",
                LastName = "Gaudreau",
                TeamName = "Canucks",
                Position = "Left Wing"
            },
            new Player {
                PlayerId = 15,
                JerseyNumber = 58,
                FirstName = "Kris",
                LastName = "Letang",
                TeamName = "Sharks",
                Position = "Defense"
            },
            new Player {
                PlayerId = 16,
                JerseyNumber = 40,
                FirstName = "Tuukka",
                LastName = "Rask",
                TeamName = "Ducks",
                Position = "Goaltender"
            },
            new Player {
                PlayerId = 17,
                JerseyNumber = 16,
                FirstName = "Mitch",
                LastName = "Marner",
                TeamName = "Blackhawks",
                Position = "Right Wing"
            },
            new Player {
                PlayerId = 18,
                JerseyNumber = 11,
                FirstName = "Anze",
                LastName = "Kopitar",
                TeamName = "Lightening",
                Position = "Center"
            },
            new Player {
                PlayerId = 19,
                JerseyNumber = 72,
                FirstName = "Sergei",
                LastName = "Bobrovsky",
                TeamName = "Oilers",
                Position = "Goaltender"
            },
            new Player {
                PlayerId = 20,
                JerseyNumber = 17,
                FirstName = "Ryan",
                LastName = "O'Reilly",
                TeamName = "Canucks",
                Position = "Center"
            },
            new Player {
                PlayerId = 21,
                JerseyNumber = 29,
                FirstName = "Marc-Andre",
                LastName = "Fleury",
                TeamName = "Sharks",
                Position = "Goaltender"
            },
            new Player {
                PlayerId = 22,
                JerseyNumber = 93,
                FirstName = "Mika",
                LastName = "Zibanejad",
                TeamName = "Lightening",
                Position = "Center"
            },
            new Player {
                PlayerId = 23,
                JerseyNumber = 74,
                FirstName = "John",
                LastName = "Carlson",
                TeamName = "Ducks",
                Position = "Defense"
            },
            new Player {
                PlayerId = 24,
                JerseyNumber = 88,
                FirstName = "David",
                LastName = "Pastrnak",
                TeamName = "Blackhawks",
                Position = "Right Wing"
            },
            new Player {
                PlayerId = 25,
                JerseyNumber = 59,
                FirstName = "Roman",
                LastName = "Josi",
                TeamName = "Leafs",
                Position = "Defense"
            },
            new Player {
                PlayerId = 26,
                JerseyNumber = 19,
                FirstName = "Jonathan",
                LastName = "Toews",
                TeamName = "Flames",
                Position = "Center"
            },
            new Player {
                PlayerId = 27,
                JerseyNumber = 37,
                FirstName = "Patrice",
                LastName = "Bergeron",
                TeamName = "Oilers",
                Position = "Center"
            },
            new Player {
                PlayerId = 28,
                JerseyNumber = 10,
                FirstName = "Artemi",
                LastName = "Panarin",
                TeamName = "Canucks",
                Position = "Left Wing"
            },
            new Player {
                PlayerId = 29,
                JerseyNumber = 71,
                FirstName = "Evgeni",
                LastName = "Malkin",
                TeamName = "Sharks",
                Position = "Center"
            },
            new Player {
                PlayerId = 30,
                JerseyNumber = 21,
                FirstName = "Sidney",
                LastName = "Hoyt",
                TeamName = "Blackhawks",
                Position = "Defense"
            },
        };

        return players;
    }
}