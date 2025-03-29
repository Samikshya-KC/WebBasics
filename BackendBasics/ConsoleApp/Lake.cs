public class Lake
{
    public Lake(){
        
    }
    public  Lake(string n,string l,float d,float a,string t){
        name=n;
        location=l;
        depth=d;
        altitude=a;
        typeOfLake=t;

    }
public string name;
public string location;
public float depth;
public float altitude;
public string typeOfLake;
public void LakeInfo(){
    var LakeInfo =$"This is the {name} lake and it is located in {location}.It is a {typeOfLake} type lake with a depth of {depth} meters.It is situated at an altitude of {altitude} meters";
Console.WriteLine(LakeInfo);

}
}

 