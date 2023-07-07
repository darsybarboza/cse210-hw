using System;

class Video {

    protected string _title;
    protected string _author;
    protected int _length;


    public Video (string title , string author , int length){

        _title = title;
        _author = author;
        _length = length;

    }

    List <Comment> comments = new List<Comment> {
        new Comment (),
        new Comment (),
        new Comment (),
    };


    public int GetNumberComment(){
        return comments.Count;
    }

    public void display(){
        Console.WriteLine ($"Title : { _title } , Author: {_author} , Duration: { _length}");
        Console.WriteLine ($"Comments : { GetNumberComment()}");
        foreach (Comment comment in comments){
            comment.display();
        }
    }
}