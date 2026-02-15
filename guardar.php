<?php
$host = "localhost";
$usuario = "root";
$contrasena = "";
$base_datos = "inventario";

$conexion = mysqli_connect($host, $usuario, $contrasena, $base_datos);
mysqli_set_charset($conexion, "utf8mb4");

$sql = "SELECT MAX(id) AS ultimo_id FROM articulos";
$resultado = mysqli_query($conexion, $sql);
$datos = mysqli_fetch_assoc($resultado);

$ultimo_id_real = $datos['ultimo_id'];
$siguiente_id = $ultimo_id_real + 1;

mysqli_query($conexion, "ALTER TABLE articulos AUTO_INCREMENT = $siguiente_id");

$id = isset($_POST['id']) ? $_POST['id'] : 0;
$nombre = $_POST['nombre'];
$stock = $_POST['stock'];
$imagen = $_POST['imagen'];
$precio = $_POST['precio'];

if ($id > 0) {
    $sql = "UPDATE articulos 
            SET nombre='$nombre', stock='$stock', imagen='$imagen', precio='$precio'
            WHERE id=$id";
} 
else {
    $sql = "INSERT INTO articulos (nombre, stock, imagen, precio)
            VALUES ('$nombre', '$stock', '$imagen', '$precio')";
}

mysqli_query($conexion, $sql);

header("Location: index.php");
exit;
?>
