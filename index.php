<?php
$host = "localhost";
$usuario = "root";
$contrasena = "";
$base_datos = "inventario";

$conexion = mysqli_connect($host, $usuario, $contrasena, $base_datos);
mysqli_set_charset($conexion, "utf8mb4");

$busqueda = isset($_GET['q']) ? $_GET['q'] : "";
$orden = isset($_GET['orden']) ? $_GET['orden'] : "asc";

$sql = "SELECT * FROM articulos";

if ($busqueda != "") {
    $sql .= " WHERE nombre LIKE '%$busqueda%'";
}

$sql .= " ORDER BY nombre " . ($orden == "desc" ? "DESC" : "ASC");

$resultado = mysqli_query($conexion, $sql);
?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Inventario</title>
    <link rel="stylesheet" href="style.css">
    <script>
        function confirmarBorrado(nombre) {
            return confirm("¿Seguro que quieres borrar " + nombre + "?");
        }
    </script>
</head>
<body>
<div class="contenedor-principal">
    <h1>Inventario</h1>

    <div class="barra-superior">
        <form method="get">
            <input type="text" name="q" placeholder="Buscar..." value="<?= $busqueda ?>">
            <button type="submit">Buscar</button>
        </form>

        <div class="grupo-botones">
            <a class="boton-secundario" href="index.php?orden=asc&q=<?= $busqueda ?>">A-Z</a>
            <a class="boton-secundario" href="index.php?orden=desc&q=<?= $busqueda ?>">Z-A</a>
            <a class="boton" href="formulario.php">Nuevo artículo</a>
        </div>
    </div>

    <table class="tabla-productos">
        <tr>
            <th>Imagen</th>
            <th>Nombre</th>
            <th>Stock</th>
            <th>Precio</th>
            <th>Acciones</th>
        </tr>

        <?php
        while ($fila = mysqli_fetch_assoc($resultado)) {
            echo "<tr>";
            echo "<td><img class='imagen-producto' src='{$fila['imagen']}'></td>";
            echo "<td>{$fila['nombre']}</td>";
            echo "<td>{$fila['stock']}</td>";
            echo "<td>" . number_format($fila['precio'], 2) . " €</td>";
            echo "<td>";
            echo "<a class='boton-editar' style='margin-right:10px;' href='formulario.php?id=" . $fila['id'] . "'>Editar</a>";
            echo "<form action='borrar.php' method='post' style='display:inline;' onsubmit=\"return confirmarBorrado('{$fila['nombre']}')\">";
            echo "<input type='hidden' name='id' value='{$fila['id']}'>";
            echo "<button class='boton-peligro'>Borrar</button>";
            echo "</form>";
            echo "</td>";
            echo "</tr>";
        }
        ?>
    </table>
</div>
</body>
</html>
