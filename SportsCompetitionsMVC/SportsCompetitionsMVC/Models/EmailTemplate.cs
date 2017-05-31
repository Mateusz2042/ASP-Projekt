using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsCompetitions.Models
{

    public static class EmailTemplate
    {
        public static string generateEmail(string bodyPartial, string user)
        {
            string body =
                          @"<html xmlns=""http://www.w3.org/1999/xhtml"">
<head>
<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8""/>
<title>SportsCompetitions</title>
</head>

<body>
<table width = ""600"" border= ""0"" align= ""center"" cellpadding= ""0"" cellspacing= ""0"" >
  <tr>
    <td align= ""left"" valign= ""top"" ><img src= ""http://www.ilikewallpaper.net/iphone-panoramic-wallpapers/download/15752/Ripe-Wheat-iphone-panoramic-wallpaper-ilikewallpaper_com.jpg"" width= ""600"" height= ""106"" style= ""display:block;"" ></td >
  </tr>
  <tr>
    <td align= ""center"" valign= ""top"" bgcolor= ""#f1f69d"" style= ""background-color:#f1f69d; font-family:Arial, Helvetica, sans-serif; font-size:13px; color:#000000; padding:10px;"" ><table width= ""100%"" border= ""0"" cellspacing= ""0"" cellpadding= ""0"" style= ""margin-top:10px;"" >
        <tr>
          <td align= ""left"" valign= ""top"" style= ""font-family:Arial, Helvetica, sans-serif; font-size:13px; color:#525252;"">
          <img src= ""http://ndl.mgccw.com/mu3/000/706/613/sss/162b25ed9a2240be9582247f895250c0_small.png"" width= ""213"" height= ""319"" align= ""right"" style= ""margin-left:10px;"">
          <div style= ""font-family:Georgia, 'Times New Roman', Times, serif; font-size:56px; color:#000000;""> Potwierdź swój email <span style=""color:#478730;"">*</span></div>
          <div style = ""font-size:28px;"" ><br> Witaj "
            + user+
            @" ,dziękujemy za rejestrację, kliknij poniższy link aby uzyskać pełny dostęp do SportsCompetitions i brać udział w zawodach</div>
            <div> <br>"+ bodyPartial
              
              + @"<br>
            </div></td>
        </tr>
      </table></td>
  </tr>
  <tr>
    <td align = ""left"" valign= ""top"" bgcolor= ""#478730"" style= ""background-color:#478730;"" ><table width= ""100%"" border= ""0"" cellspacing= ""0"" cellpadding= ""15"" >
      <tr>
        <td align= ""left"" valign= ""top"" style= ""color:#ffffff; font-family:Arial, Helvetica, sans-serif; font-size:13px;""> Company Address<br>
          Admin Pawel<br>
          Phone: (123) 456-789 <br>
          Email: <a href = ""mailto:SportsCompetitions@gmail.com"" style=""color:#ffffff; text-decoration:none;"">name @yourcompanyname.com</a><br>

            Website: <a href = ""http://www.sportiATH.com"" target= ""_blank"" style= ""color:#ffffff; text-decoration:none;"" > www.yourcompanyname.com </ a ></ td >
  
        </tr>
  
      </table ></td>
  
    </tr>
  </table>
  </body>
  </html>";

            return body;
        }

    }


}