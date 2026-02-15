<?php
$host = "localhost";
$usuario = "root";
$contrasena = "";
$base_datos = "inventario";

$conexion = mysqli_connect($host, $usuario, $contrasena, $base_datos);
mysqli_set_charset($conexion, "utf8mb4");

$id = isset($_GET['id']) ? $_GET['id'] : 0;

$nombre = "";
$stock = "";
$imagen = "";
$precio = "";

if ($id > 0) {
    $sql = "SELECT * FROM articulos WHERE id=$id";
    $resultado = mysqli_query($conexion, $sql);

    if ($fila = mysqli_fetch_assoc($resultado)) {
        $nombre = $fila['nombre'];
        $stock = $fila['stock'];
        $imagen = $fila['imagen'];
        $precio = $fila['precio'];
    }
}
?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title><?php echo ($id > 0 ? "Editar artículo" : "Nuevo artículo"); ?></title>
    <link rel="stylesheet" href="style.css">
</head>
<body>

<div class="contenedor-principal">
    <h1><?php echo ($id > 0 ? "Editar artículo" : "Nuevo artículo"); ?></h1>

    <form action="guardar.php" method="post">

        <?php
        if ($id > 0) {
            echo "<input type='hidden' name='id' value='$id'>";
        }
        ?>

        <div class="formulario-dos-columnas">

            <div class="columna">
                <label>Nombre:</label>
                <input type="text" name="nombre" required value="<?php echo $nombre; ?>">

                <label>Ruta imagen:</label>
                <input type="text" name="imagen" required value="<?php echo $imagen; ?>">
            </div>

            <div class="columna">
                <label>Stock:</label>
                <input type="number" name="stock" required min="0" value="<?php echo $stock; ?>">

                <label>Precio (€):</label>
                <input type="number" step="0.01" name="precio" required value="<?php echo $precio; ?>">
            </div>

        </div>

        <div class="botones-centro">
            <button type="submit">Guardar</button>
            <a class="boton-volver" href="index.php">Volver</a>
        </div>

    </form>
</div>

</body>
</html>
