using Microsoft.AspNetCore.Mvc;
using StudentDirectoryApi.Models;

namespace StudentDirectoryApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentDirectoryController : ControllerBase
{
    //making a list of students with the student list model
    public List<StudentListModel> studentsList = new List<StudentListModel>()
        {
            // call the constructor to add the students
            new StudentListModel(){
                firstName = "Danny",
                lastName = "Tran",
                slackName = "Danny Tran",
                email = "dannytran@gmail.com",
                hobbies = "Being an awesome TA"
            }, 
            new StudentListModel(){
                firstName = "Scott",
                lastName = "Morenzone",
                slackName = "Scott Morenzone",
                email = "scottmorenzone@gmail.com",
                hobbies = "Just being the best TA"
            },
            new StudentListModel(){
                firstName = "Ken",
                lastName = "Martinez",
                slackName = "Ken Martinez",
                email = "kenmartinez@gmail.com",
                hobbies = "Being the best Boss ever!!!!"
            },
              new StudentListModel(){
            firstName = "Adam",
            lastName = "Prieto",
            slackName = "Adam Prieto",
            email = "prietoadam29@gmail.com",
            hobbies = "Travel, Exercising, Music, TV"
         },
         new StudentListModel(){
            firstName = "Aisha",
            lastName = "Mashrah",
            slackName = "Aisha Mashrah",
            email = "amashrah@codestack.co",
            hobbies = "Workout, Travel, Painting"
         },
         new StudentListModel(){
            firstName = "Amar",
            lastName = "Mann",
            slackName = "Amar",
            email = "amann@codestack.co",
            hobbies = "Tree Shaping, Beetle Fighting, News Raiding, Extreme Ironing, Kicking Rocks"
         },
         new StudentListModel(){
            firstName = "Andrea",
            lastName = "Burr",
            slackName = "Andrea Burr",
            email = "aburr@codestack.co",
            hobbies = "Showing Livestock, Horse Riding"
         },
         new StudentListModel(){
            firstName = "Andrew",
            lastName = "Nilsson",
            slackName = "Drew Nilsson",
            email = "anilsson@codestack.co",
            hobbies = "Playing Video Games"
         },
         new StudentListModel(){
            firstName = "Arley",
            lastName = "Martinez",
            slackName = "Arely Martinez",
            email = "amartinez@codestack.co",
            hobbies = "Listening to Music and Watching TV"
         },
         new StudentListModel(){
            firstName = "Brian",
            lastName = "Mallory",
            slackName = "Brian Mallory",
            email = "bmallory@codestack.co",
            hobbies = "Golf, Guitar, Gaming, D&D"
         },
         new StudentListModel(){
            firstName = "Carlos",
            lastName = "Felipe",
            slackName = "Carlos",
            email = "cfelipe@codestack.co",
            hobbies = "Singing in the Car, Watching YouTube Videos, Anime"
         },
         new StudentListModel(){
            firstName = "Caroline",
            lastName = "Hana",
            slackName = "Caroline Hana",
            email = "chana@codestack.co",
            hobbies = "Play Games, Anime, Hanging Out With Friends"
         },
         new StudentListModel(){
            firstName = "Chris",
            lastName = "Martinez",
            slackName = "Chris Martinez",
            email = "cmartinez@codestack.co",
            hobbies = "Photography, Ping Pong"
         },
         new StudentListModel(){
            firstName = "Christopher",
            lastName = "Prado",
            slackName = "Christopher Prado",
            email = "cprado@codestack.co",
            hobbies = "Music, Defense Against the Dark Arts, Potions, Soccer"
         },
         new StudentListModel(){
            firstName = "Cuong",
            lastName = "Le",
            slackName = "Brandon Le",
            email = "ble@codestack.co",
            hobbies = "Sleeping, Eating"
         },
         new StudentListModel(){
            firstName = "Daniel",
            lastName = "Decoito",
            slackName = "Daniel Decoito",
            email = "danieldecoito@gmali.com",
            hobbies = "Cooking, Botany, Storytelling, Gaming"
         },
         new StudentListModel(){
            firstName = "Elizar",
            lastName = "Garcia",
            slackName = "Elizar Garcia",
            email = "egarcia@codestack.co",
            hobbies = "Bowling, Video Games, Sleeping"
         },
         new StudentListModel(){
            firstName = "Fernando",
            lastName = "Aguilar",
            slackName = "Freddy Aguilar",
            email = "faguilar@codestack.co",
            hobbies = "Reading, Writing, Drawing, Video Games"
         },
         new StudentListModel(){
            firstName = "Griffin",
            lastName = "Parker",
            slackName = "Griffin Parker",
            email = "gparker@codestack.co",
            hobbies = "Singing, Reading, Video Games"
         },
         new StudentListModel(){
            firstName = "Harrison",
            lastName = "Busby",
            slackName = "Harrison Busby",
            email = "hbusby@codestack.co",
            hobbies = "Piano"
         },
         new StudentListModel(){
            firstName = "Isaiah",
            lastName = "Ferguson",
            slackName = "Isaiah Ferguson",
            email = "iferguson@codestack.co",
            hobbies = "BJJ, MT, Hiking, Dancing, Baking, Raving, Tricking, Anime"
         },
         new StudentListModel(){
            firstName = "Jacob",
            lastName = "Dekok",
            slackName = "Jacob Dekok",
            email = "jdekok@codestack.co",
            hobbies = "Video Games"
         },
         new StudentListModel(){
            firstName = "Jasmine",
            lastName = "Leek",
            slackName = "Jasmine Leek",
            email = "jleek@codestack.co",
            hobbies = "Puzzles, Baking, Crafts"
         },
         new StudentListModel(){
            firstName = "Jeremy",
            lastName = "Lapham",
            slackName = "Muscle Baby",
            email = "jlapham@codestack.co",
            hobbies = "Wrestling, Power Lifting, Body Building, Eating, Sleeping, Video Games"
         },
         new StudentListModel(){
            firstName = "Jessie",
            lastName = "Lamzon",
            slackName = "Jessie Lamzon",
            email = "jlamzon@codestack.co",
            hobbies = "Fix Electronics, Video Editing, Cooking, Traveling"
         },
         new StudentListModel(){
            firstName = "John",
            lastName = "Magpantay",
            slackName = "John Magpantay",
            email = "jmagpantay@codestack.co",
            hobbies = "Hoop, Workout, FPS Video Games"
         },
         new StudentListModel(){
            firstName = "Jovann",
            lastName = "Contreras",
            slackName = "Jovann Contreras",
            email = "jcontreras@codestack.co",
            hobbies = "Collecting Comics & Vintage Items"
         },
         new StudentListModel(){
            firstName = "Kenneth",
            lastName = "Fujimura",
            slackName = "Kenneth Fujimura",
            email = "kfujimura@codestack.co",
            hobbies = "Games, Sports, Model Kits, Anime, Naps, Culinary Tourism"
         },
         new StudentListModel(){
            firstName = "Kent",
            lastName = "Tupas",
            slackName = "Kent Tupas",
            email = "ktupas@codestack.co",
            hobbies = "Weeb"
         },
         new StudentListModel(){
            firstName = "Lerissa",
            lastName = "Lazar",
            slackName = "Lerissa Lazar",
            email = "llazar@codestack.co",
            hobbies = "Drawing, Anime"
         },
         new StudentListModel(){
            firstName = "Madeline",
            lastName = "Gowan",
            slackName = "Maddie Gowan",
            email = "mgowan@codestack.co",
            hobbies = "Drawing, Rodents, Drawing Rodents"
         },
         new StudentListModel(){
            firstName = "Manuel",
            lastName = "Leyva",
            slackName = "Manuel Leyva",
            email = "mleyva@codestack.co",
            hobbies = "Soccer, Baseball, Football, Photography"
         },
         new StudentListModel(){
            firstName = "Marcel",
            lastName = "Rodriguez",
            slackName = "Marcel Rodriguez",
            email = "mrodriguez@codestack.co",
            hobbies = "Card Games"
         },
         new StudentListModel(){
            firstName = "Mark",
            lastName = "Ramirez",
            slackName = "Mark Ramirez",
            email = "mramirez@codestack.co",
            hobbies = "Video Games, Hydration"
         },
         new StudentListModel(){
            firstName = "Mauricio",
            lastName = "Acosta",
            slackName = "Mauricio Acosta",
            email = "macosta@codestack.co",
            hobbies = "WarZone, Cars, YouTube, Flipping Cars"
         },
         new StudentListModel(){
            firstName = "N. Harrison",
            lastName = "Wilkins",
            slackName = "Harrison Wilkins",
            email = "nwilkins@codestack.co",
            hobbies = "Motorsport, Video Games, Skateboarding"
         },
         new StudentListModel(){
            firstName = "Nicolas",
            lastName = "Acosta",
            slackName = "Nicolas Acosta",
            email = "nacosta@codestack.co",
            hobbies = "Reading, Exploring, Dao"
         },
         new StudentListModel(){
            firstName = "Noah",
            lastName = "Bague",
            slackName = "Zeke",
            email = "nbague@codestack.co",
            hobbies = "Post Malone, Wolves, Music, Video Games, Cars, Pokemon, Cosplay"
         },
         new StudentListModel(){
            firstName = "Pedro",
            lastName = "Castaneda",
            slackName = "Pedro Castaneda",
            email = "pcastaneda@codestack.co",
            hobbies = "Archery, Skateboarding, Camping, Hiking, Traveling"
         },
         new StudentListModel(){
            firstName = "Rafael",
            lastName = "Manzo",
            slackName = "Rafael Manzo",
            email = "prormanzo@gmail.com",
            hobbies = "Dogs, Video Games, Finance, Business, Films, Hiking"
         },
         new StudentListModel(){
            firstName = "Reed",
            lastName = "Goodwin",
            slackName = "Reed Goodwin",
            email = "rgoodwin@codestack.co",
            hobbies = "Skateboarding, Video Games"
         },
         new StudentListModel(){
            firstName = "Richard",
            lastName = "Johnson",
            slackName = "Richard Johnson",
            email = "rjohnson@codestack.co",
            hobbies = "Drawing, Video Games, YouTube"
         },
         new StudentListModel(){
            firstName = "Samuel",
            lastName = "Laguna",
            slackName = "Samuel Laguna",
            email = "slaguna@codestack.co",
            hobbies = "Football, Video Games"
         },
         new StudentListModel(){
            firstName = "Shaun",
            lastName = "Aguirre-Reyes",
            slackName = "Shaun Aguirre-Reyes",
            email = "saguirre-reyes@codestack.co",
            hobbies = "Writing, Gaming, Camping, Music"
         },
         new StudentListModel(){
            firstName = "Ulises",
            lastName = "Ortega",
            slackName = "Ulises Ortega",
            email = "uortega@codestack.co",
            hobbies = "Gaming, Rollerblading, Skimboarding, Board Games"
         }
        };


        //endpoint that gets a student by their first name
        [HttpGet]
        [Route("GetStudentByFirstName/{studentFirstName}")]
        public StudentListModel GetStudentByFirstName(string studentFirstName)
        {
            StudentListModel result = new StudentListModel(){
                firstName = "N/A",
                lastName  = "N/A",
                slackName = "N/A",
                email = "N/A",
                hobbies = "N/A"
            };

            for(int i = 0; i < studentsList.Count; i++)
            {
                // condition to check the studentlist firstname to our variable firstname

                if(studentsList[i].firstName == studentFirstName)
                {
                    result = studentsList[i];
                    break;
                }
                // else{
                //     result.firstName = "N/A";
                //     result.lastName = "N/A";
                //     result.slackName = "N/A";
                //     result.email = "N/A";
                //     result.hobbies = "N/A";
                // }
            }

            return result;
        }

}
