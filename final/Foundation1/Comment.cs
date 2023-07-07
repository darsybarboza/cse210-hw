using System;

class Comment {
    protected string _name;
    protected string _comment;


    List <string> names = new List<string> {
        "Karla",
        "Sophie",
        "Carl",
        "Sam",
        "Mauro",
        "Daniel",
        "Colton",
        "Annie"

    };


    List <string> comments = new List<string> {
        "This is too cool you have a new follower!!",
        "Good Job , I follow you!!",
        "This video looks great!",
        "It all looks very cool! I can't wait to see more!",
        "This is fantastic xd",
        "I hope to see new news, excellent videoooo",
        "I love seeing their reviews, they are very objective in everything and they always give their honest opinion",
        "I love it!!!!!",
        "Good VIDEO! Thanks"
    };


    public Comment (){

        Random random = new Random();
        int randomIndex = random.Next (names.Count);
        _name = names [randomIndex];
        _comment = comments [random.Next(comments.Count)];
    }

    public void display(){
        Console.WriteLine ($"{_name}\n \"{_comment}\n \n ");
    }
}