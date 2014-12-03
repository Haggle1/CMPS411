<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
<title>uFR2FileSystem-List</title>
</head>

<style type="text/css">
 .fontTitle {font-family: Verdana, Arial, Helvetica, sans-serif,;font-weight:bold;font-size:20px}
 .font2 {font-family: Verdana, Arial, Helvetica, sans-serif;font-size:10px;color: black;} .font3 {font-family: Verdana, Arial, Helvetica, sans-serif;font-size:12px}    
</style>

<body style=" background-color: #f6f6f6; text-align: center; ">

<form method="post" action="">
<div align="center">
<p class="fontTitle">uFR2FileSystem DataBase</p>
<p></p>
<table border="1" class="font2">
<?php 
   $server_name='localhost';
   $server_user_name='user';
   $server_user_pass='password';   
   $database_name='ufr2filesystem';
   
   $conn=mysql_connect($server_name,$server_user_name,$server_user_pass);
        mysql_select_db($database_name,$conn);
        if (!$conn)
        {
        	die('Could not connect: ' . mysql_error());
        	      
        }
   $result=mysql_query("SELECT * FROM `content`ORDER BY ID DESC");
  
  
	echo '<tr style=" background-color: #000000; text-align: center; "><td style=" color:#ffffff; font-weight:bold;">Card UID</td>';
   	  echo '<td style=" color: #ffffff;font-weight:bold;">Date</td>';
   	  echo '<td style=" color: #ffffff;font-weight:bold;">Time</td>';
	  echo '<td style=" color: #ffffff;font-weight:bold;">Card Content</td>';
	  
   while ($row=mysql_fetch_array($result))
   {   

 
	  
   	  echo '<tr style=" background-color: #cdcfcf; text-align: center; "><td style=" color:#595959; font-size: 15px; font-weight:bold;">'.$row['IDCard'].'</td>';
   	  echo '<td >'.$row['Date'].'</td>';
   	  echo '<td style=" color: red;">'.$row['Time'].'</td>';
   	 	
		
   	  echo '<td colspan="3"><textarea cols="50" rows="5" readonly="readonly" >'.$row['Contex'].'</textarea></td></tr>';
   	  
   }
   mysql_close($conn);
   
         
?>
</table>
</div>
</form>
</body>
</html>
