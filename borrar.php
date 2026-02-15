<?php
$host = "localhost";
$usuario = "root";
$contrasena = "";
$base_datos = "inventario";

$conexion = mysqli_connect($host, $usuario, $contrasena, $base_datos);
mysqli_set_charset($conexion, "utf8mb4");

$id = $_POST['id'];

$sql = "DELETE FROM articulos WHERE id=$id";
mysqli_query($conexion, $sql);

header("Location: index.php");
exit();
?>
