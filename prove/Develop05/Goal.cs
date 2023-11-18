

class Goal
{
    
    public bool _mb_isCompleted = false;
    private string _mb_name;
    private string _mb_description;
    private int _mb_point;

    public Goal(string name, string description, int points){
        _mb_name = name;
        _mb_point = points;
        _mb_description = description;

    }

    public string getName(){
        return _mb_name;
    }

    public string getDescription(){
        return _mb_description;
    }

    public int getPoints(){
        return _mb_point;
    }

    public bool getComplete(){
        return _mb_isCompleted;
    }
    public virtual void List(int i){

    }

    public virtual string SaveFile(){
        return "";
    }
    public virtual int Complete(){
        if(_mb_isCompleted == false){
            _mb_isCompleted = true;
            return _mb_point;
        }
        else{
            return 0;
        }
    }


    
}