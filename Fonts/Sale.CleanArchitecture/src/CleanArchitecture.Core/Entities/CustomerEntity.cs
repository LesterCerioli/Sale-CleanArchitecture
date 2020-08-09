namespace CleanArchitecture.Core.Entities
{
    public CustomerEntity(Guid id, string firstname, string middlename, string  lastname, DateTime birthdate, string fulladress, int addressnumber, string email, string alternativeemail, string telephonenumber) 
    {
        Id = id;
        Firstname = firstname;
        Middlename = middlename;
        Lastname = lastname;
        Birthdate = birthdate;
        Fulladress = fulladress;
        Addressnumber = addressnumber;
        Email = email;
        Alternativeemail = alternativeemail;
        Telephonenumber = telephonenumber;
        
    }

    protected CustomerEntity() {}

    public string Firstname { get; set; }  
    public string Middlename {get; set;}               
    public string Lastname { get; set; }
    public datetime Birthdate { get; set; }
    public string Fulladress { get; set; }
    public int Addressnumber { get; set; }
    public string Email { get; set; }
    public string Alternativeemail { get; set; }
    public string Telephonenumber { get; set; }


}

    
        