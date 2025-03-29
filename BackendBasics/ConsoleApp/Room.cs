
public class Room
{
    public Room(){
        
    }
    public Room(string c,byte f,double l,double w,double h){
        paintColor=c;
        floor=f;
        lengthFt=l;
        widthFt=f;
        heightFt=h;
    }

    
    //Fields
    public double widthFt;
    public double lengthFt;
    public double heightFt;
    public string paintColor;
    public byte floor;

    public void DisplayInfo()
    {
        var info = $"Hey guys,we have a room in a floor {floor} which is painted {paintColor}. It's dimension is {lengthFt}X{widthFt}X{heightFt}";
        Console.WriteLine(info);
    }

}