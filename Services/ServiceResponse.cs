namespace MovieStar.Services;

public class ServiceResponse<T>{
    public T? Data {get;set;}
    public string Message {get;set;}
    public bool Status{get;set;} = true;

}