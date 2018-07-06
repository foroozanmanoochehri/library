using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for service
/// </summary>
public class service
{
	public service()
	{
		
	}
    dal dl = new dal();
    public int Id { get; set; }
    public int Userid { get; set; }
    public int Bookid { get; set; }
    public int Statusid { get; set; }
    public string Name { get; set; }
    public string Uname { get; set; }
    public string Password { get; set; }
    public int Rol_id { get; set; }

    public string Author { get; set; }
    public int AuthorId { get; set; }
    public bool Insert_users()
    {
        string comand = "insert into [Users](Name,Uname,Password,Rol_id)values(@Name,@Uname,@Password,@Rol_id)";
        List<SqlParameter> parametrlist = new List<SqlParameter>();
        var name_parametr = new SqlParameter("@Name", this.Name);
        var Uname_parametr = new SqlParameter("@Uname", this.Uname);
        var Password_parametr = new SqlParameter("@Password", this.Password);
        var Rol_parametr = new SqlParameter("@Rol_id", this.Rol_id);
        parametrlist.Add(name_parametr);
        parametrlist.Add(Uname_parametr);
        parametrlist.Add(Password_parametr);
        parametrlist.Add(Rol_parametr);
        var db = new dal();
        var result = db.Executecomand(comand, parametrlist);
        return result;
    }
    public bool Update_users()
    {
        string comand = "update  [Users] set Name=@Name,Uname=@Uname,Password=@Password,Rol_id=@Rol_id where Id=@Id";
        List<SqlParameter> parametrlist = new List<SqlParameter>();
        var id_parametr = new SqlParameter("@Id", this.Id);
        var name_parametr = new SqlParameter("@Name", this.Name);
        var Uname_parametr = new SqlParameter("@Uname", this.Uname);
        var Password_parametr = new SqlParameter("@Password", this.Password);
        var Rol_parametr = new SqlParameter("@Rol_id", this.Rol_id);
        parametrlist.Add(id_parametr);
        parametrlist.Add(name_parametr);
        parametrlist.Add(Uname_parametr);
        parametrlist.Add(Password_parametr);
        parametrlist.Add(Rol_parametr);
        var db = new dal();
        var result = db.Executecomand(comand, parametrlist);
        return result;
    }
    public bool Delete_users()
    {
        string comand = "delete from  Users where  Id=@Id";
        List<SqlParameter> parametrlist = new List<SqlParameter>();
        var id_parametr = new SqlParameter("@Id", this.Id);

        parametrlist.Add(id_parametr);

        var db = new dal();
        var result = db.Executecomand(comand, parametrlist);
        return result;
    }
    public DataTable all_users()
    {
        string comand = "select * from Users ";





        var db = new dal();
        var result = db.get_dt(comand);
        return result;
    }
    public DataTable all_book()
    {
        string comand = "select * from Book  ";





        var db = new dal();
        var result = db.get_dt(comand);
        return result;
    }
    public DataTable all_rol()
    {
        string comand = "select * from Rols  ";





        var db = new dal();
        var result = db.get_dt(comand);
        return result;
    }

    public DataTable all_request()
    {
        string comand = "select * from Request_book  ";





        var db = new dal();
        var result = db.get_dt(comand);
        return result;
    }
    public DataTable get_name()
    {
        string comand = "select Uname from Users where Id='" + Id + "'  ";





        var db = new dal();
        var result = db.get_dt(comand);
        return result;
    }
    public DataTable get_book()
    {
        string comand = "select Name from Book where Id='" + Bookid + "'  ";





        var db = new dal();
        var result = db.get_dt(comand);
        return result;
    }
    public DataTable get_status()
    {
        string comand = "select Name from Status where Id='" + Statusid + "'  ";





        var db = new dal();
        var result = db.get_dt(comand);
        return result;
    }
    public DataTable all_Aenre()
    {
        string comand = "select * from Aenre  ";





        var db = new dal();
        var result = db.get_dt(comand);
        return result;
    }
    public DataTable all_status()
    {
        string comand = "select * from Status ";





        var db = new dal();
        var result = db.get_dt(comand);
        return result;
    }

    public DataTable login_user()
    {
        string comand = "select * from Users where Uname=@Uname and Password=@Password and Rol_id=@Rol_id ";

        List<SqlParameter> parametrlist = new List<SqlParameter>();

        var Uname_parametr = new SqlParameter("@Uname", this.Uname);
        var Password_parametr = new SqlParameter("@Password", this.Password);
        var Rol_parametr = new SqlParameter("@Rol_id", this.Rol_id);

        parametrlist.Add(Uname_parametr);
        parametrlist.Add(Password_parametr);
        parametrlist.Add(Rol_parametr);



        var db = new dal();
        var result = db.get_login(comand, parametrlist);
        return result;
    }
    public DataTable last_id()
    {
        string comand = "select Id from Users order by Id desc ";





        var db = new dal();
        var result = db.get_dt(comand);
        return result;
    }
    public bool Insert_book()
    {
        string comand = "insert into [Book](Name,Author,Aenre_id)values(@Name,@Author,@Aenre_id)";
        List<SqlParameter> parametrlist = new List<SqlParameter>();
        var name_parametr = new SqlParameter("@Name", this.Name);
        var author_parametr = new SqlParameter("@Author", this.Author);
        var au_id_parametr = new SqlParameter("@Aenre_id", this.AuthorId);

        parametrlist.Add(name_parametr);
        parametrlist.Add(author_parametr);
        parametrlist.Add(au_id_parametr);

        var db = new dal();
        var result = db.Executecomand(comand, parametrlist);
        return result;
    }
    public bool Update_book()
    {
        string comand = "update  [Book] set Name=@Name,Author=@Author,Aenre_id=@Aenre_id where Id=@Id";
        List<SqlParameter> parametrlist = new List<SqlParameter>();
        var id_parametr = new SqlParameter("@Id", this.Id);
        var name_parametr = new SqlParameter("@Name", this.Name);
        var author_parametr = new SqlParameter("@Author", this.Author);
        var au_id_parametr = new SqlParameter("@Aenre_id", this.AuthorId);
        parametrlist.Add(id_parametr);
        parametrlist.Add(name_parametr);
        parametrlist.Add(author_parametr);
        parametrlist.Add(au_id_parametr);
        var db = new dal();
        var result = db.Executecomand(comand, parametrlist);
        return result;
    }
    public bool Delete_book()
    {
        string comand = "delete from  Book where  Id=@Id";
        List<SqlParameter> parametrlist = new List<SqlParameter>();
        var id_parametr = new SqlParameter("@Id", this.Id);

        parametrlist.Add(id_parametr);

        var db = new dal();
        var result = db.Executecomand(comand, parametrlist);
        return result;
    }




    public bool Insert_Aenre()
    {
        string comand = "insert into [Aenre](Name)values(@Name)";
        List<SqlParameter> parametrlist = new List<SqlParameter>();
        var name_parametr = new SqlParameter("@Name", this.Name);


        parametrlist.Add(name_parametr);


        var db = new dal();
        var result = db.Executecomand(comand, parametrlist);
        return result;
    }
    public bool Update_Aenre()
    {
        string comand = "update  [Aenre] set Name=@Name where Id=@Id";
        List<SqlParameter> parametrlist = new List<SqlParameter>();
        var id_parametr = new SqlParameter("@Id", this.Id);
        var name_parametr = new SqlParameter("@Name", this.Name);

        parametrlist.Add(id_parametr);
        parametrlist.Add(name_parametr);

        var db = new dal();
        var result = db.Executecomand(comand, parametrlist);
        return result;
    }
    public bool Delete_Author()
    {
        string comand = "delete from  Aenre where  Id=@Id";
        List<SqlParameter> parametrlist = new List<SqlParameter>();
        var id_parametr = new SqlParameter("@Id", this.Id);

        parametrlist.Add(id_parametr);

        var db = new dal();
        var result = db.Executecomand(comand, parametrlist);
        return result;
    }


    public bool Insert_reques()
    {
        string comand = "insert into [Request_book](Uid,Bid,Sid)values(@Uid,@Bid,@Sid)";
        List<SqlParameter> parametrlist = new List<SqlParameter>();

        var uid_parametr = new SqlParameter("@Uid", this.Userid);
        var bid_parametr = new SqlParameter("@Bid", this.Bookid);
        var sid_parametr = new SqlParameter("@Sid", this.Statusid);
        parametrlist.Add(uid_parametr);
        parametrlist.Add(bid_parametr);
        parametrlist.Add(sid_parametr);

        var db = new dal();
        var result = db.Executecomand(comand, parametrlist);
        return result;
    }
    public bool update_reques()
    {
        string comand = "update  Request_book set Uid=@Uid,Bid=@Bid,Sid=@Sid where Id=@Id";
        List<SqlParameter> parametrlist = new List<SqlParameter>();
        var id_parametr = new SqlParameter("@id", this.Id);
        var uid_parametr = new SqlParameter("@Uid", this.Userid);
        var bid_parametr = new SqlParameter("@Bid", this.Bookid);
        var sid_parametr = new SqlParameter("@Sid", this.Statusid);
        parametrlist.Add(uid_parametr);
        parametrlist.Add(bid_parametr);
        parametrlist.Add(sid_parametr);

        var db = new dal();
        var result = db.Executecomand(comand, parametrlist);
        return result;
    }

    public bool Delete_request()
    {
        string comand = "delete from  Request_book where  Id=@Id";
        List<SqlParameter> parametrlist = new List<SqlParameter>();
        var id_parametr = new SqlParameter("@Id", this.Id);

        parametrlist.Add(id_parametr);

        var db = new dal();
        var result = db.Executecomand(comand, parametrlist);
        return result;
    }
}