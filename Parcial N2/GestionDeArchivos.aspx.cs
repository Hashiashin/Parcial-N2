using Desempeño_N_2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial_N2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        public void cargarGrilla()
        {
            string path = $"{Server.MapPath(".")}/{Session["usuario"].ToString()}";
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                List<Archivo> fileList = new List<Archivo>();
                foreach (string file in files)
                {
                    var fileNew = new Archivo(Path.GetFileName(file), file);
                    fileList.Add(fileNew);
                }
                GridView1.DataSource = fileList;
                GridView1.DataBind();

            }
        }





        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                cargarGrilla();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            {
                if (Session["usuario"] != null)
                {
                    string path = $"{Server.MapPath(".")}/{Session["usuario"].ToString()}";

                    if (Directory.Exists(path))
                    {
                        foreach (HttpPostedFile archivo in FileUpload1.PostedFiles)
                        {
                            FileUpload1.SaveAs($"{path}/{archivo.FileName}");
                        }

                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Archivo subido con éxito.'); window.location.href='/Index.aspx';", true);
                    }
                    else
                    {
                        Directory.CreateDirectory(path);
                        foreach (HttpPostedFile archivo in FileUpload1.PostedFiles)
                        {
                            FileUpload1.SaveAs($"{path}/{archivo.FileName}");
                        }
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Archivo subido con éxito.'); window.location.href='/Index.aspx';", true);
                    }
                }
                else
                {

                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Error: El usuario no está autenticado.');window.location.href='/Index.aspx';", true);
                }
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Descargar")
            {
                GridViewRow registro = GridView1.Rows[Convert.ToInt32(e.CommandArgument)];
                string filePath = registro.Cells[2].Text;
                Response.ContentType = "application/octet-stream";
                Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath));
                Response.TransmitFile(filePath);
                Response.End();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }


    }

}