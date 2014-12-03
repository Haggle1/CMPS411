
<?php 

/* Scanner Stuffs, leave commented. (Dustin you will need to uncomment
   $contex=$_POST['contex'];
  
   if (!get_magic_quotes_gpc())
  {
  	$contex=addslashes($contex);  
  }
  */
 
 //Change $name to your server name!
 $name = "TONYLAP";
 $connect = array("Database"=>"SchoolTracker");
 
$conn = sqlsrv_connect($name, $connect);

if ($conn) {

	$sql = "INSERT INTO Attendances (SID, Clock_In) VALUES (?, ?)";
	//More scanner stuff, Dustin comment the following line back in and the other $params line out (to use the scanner info)
	//$params = array('$contex', "2011-04-12T00:00:00.000");
	
	//SID needs to already exist in the Studnet table change 222 so it reflects your table!
	$params = array("222", "2011-04-12T00:00:00.000");
	$stmt = sqlsrv_query( $conn, $sql, $params);
	if( $stmt === false ) {
		die( print_r( sqlsrv_errors(), true));
	}
}
else{
 echo"Error<br />";
 die(print_r(sqlsrv_errors(), true));
}






?>
