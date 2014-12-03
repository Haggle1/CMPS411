<html>
<head>
<title>uFR2FileSystem</title>
</head>
<body>
<?php 
   $idcard=$_POST['idcard'];
   $date=$_POST['date'];
   $time=$_POST['time'];
   $contex=$_POST['contex'];
   
   
   if (!get_magic_quotes_gpc())
  {
  	$idcard=addslashes($idcard);
  	$date=addslashes($date);
  	$time=addslashes($time);
  	$contex=addslashes($contex);  
  }
   if (empty($idcard)) exit; 
   
   
   $server_name='localhost';
   $server_user_name='user';
   $password='password'; 
   $database_name='ufr2filesystem';
   
 
   
   
   echo $file_path;
   
  
   $save_to_database=true;
   $save_to_file=true;   
   
  if ($save_to_database)
  {
   $db=mysql_connect($server_name,$server_user_name,$password);
        mysql_select_db($database_name,$db);
    
	if (!$db)
    {
     	die('Could not connect: ' . mysql_error());
        exit;
	}
    
	
	
    $query="INSERT INTO content (IDCard,Date,Time,Contex) VALUES
            ('".$idcard."', 
             '".$date."',
             '".$time."',
             '".$contex."'
             )";
    
	$result=mysql_query($query);   
    mysql_close($db);
    }
	
	 
	if ($save_to_file)
	{
	 $file_path=$_SERVER['DOCUMENT_ROOT'];
	 $file_log_path='/demo/log/';
	 $file_name='uFR2FileSystem.txt';	 
     $fp=fopen($file_path.$file_log_path.$file_name,'w+');
     if (!$fp)      	
          {
		    die ('file error');		   				    
			exit;
		  }
     $text_file=$idcard." ".$date." ".$time."\n".$contex;
     fwrite($fp,$text_file,strlen($text_file));
     fclose($fp);
	 }
?>

</body>
</html>
