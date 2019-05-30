using PersonRepository.Interfaces;
using PersonRepository.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

class ABM_Basic : IPersonRepositoryBasic
{
    public List<Person> People { get; set; }
    public bool IsValidPerson(Person person){
        if( (person.Age<=0)||(person.Name==null)||(person.Name=="")||!IsValidEmail(person.Email) ){
            return false;
        }else{
        return true; 
        }
    }

    public void Add(Person person)
    {
        if(People==null){
            return;
        }
        if (People.Any(x => x.Id == person.Id) ){
            return;
        }
        if(person.Age<=0){
            return;
        }
        if(!IsValidEmail(person.Email)){
            return;
        }
        if( (person.Name == null) || (person.Name == String.Empty) ){
        }
        People.Add(person);
        return;
    }
    public void Delete(int id) 
    {
        foreach (Person Persona in People){
            if(Persona.Id==id){
                People.Remove(Persona);
                return;
            }
        }
    }
    public void Update(Person person)   //asumo que me da el id de la persona a actualizar.
    {
        foreach (Person Persona in People){
            if(Persona.Id==person.Id){
                if(person.Age>0){
                    Persona.Age=person.Age;
                }
                if(person.Name!=null){
                    Persona.Name=person.Name;
                }
                if(IsValidEmail(person.Email)){
                    Persona.Email=person.Email;
                }
            }
        }
        
    }

    public int GetCountRangeAges(int min, int max)
    {
        int i=0;
        if( (min>max) || (min<=0) || (max<=0) ){
            return -1;
        }
        foreach(Person Persona in People){
            if( (Persona.Age>=min) && (Persona.Age<=max) ){
                i++;
            }
        }
        return i;
    }


    public List<Person> GetFiltered(string name, int age, string email)
        {
            List<Person> Filtro = new List<Person>();
            bool Filtromail=true,Filtroname=true,Filtroage=true;
            if(People==null){return null;}

            foreach(Person Persona in People){

                if( (name==null) || (name==String.Empty) ){
                    Filtroname=false;
                }
                else{
                    Filtroname=true;
                    if(Persona.Name==name){
                            Filtroname=false;
                    }
                }
                if( (email==null) || (email==String.Empty) ){
                    Filtromail=false;
                }
                else{
                    Filtromail=true;
                    if(Persona.Email.Contains(email)){
                        Filtromail=false;
                    }
                }
                if( age<1 ){
                    Filtroage=false;
                }
                else{
                    Filtroage=true;
                    if(Persona.Age==age){
                        Filtroage=false;
                    }
                }

                if((!Filtromail)&&(!Filtroage)&&(!Filtroname)){
                    Filtro.Add(Persona);
                }
            }
            return Filtro;
    }   
    public Person GetPerson(int Id)
    {
        foreach(Person Persona in People){
            if(Persona.Id==Id){
                return Persona;
            }
        }
        return null;
    }
    private bool IsValidEmail(string email)
    {
        return ( RegexUtilities.IsValidEmail(email) ) && (email != null) && (email != "");
    }
}