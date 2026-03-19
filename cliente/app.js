const API = "http://localhost:5120/api/articulos";

let ordenActual = "asc";

document.getElementById("buscar").addEventListener("keydown", function (e) {
    if (e.key === "Enter") {
        e.preventDefault();
        buscar();
    }
});

async function cargarArticulos() {
    const buscar = document.getElementById("buscar").value;
    const res = await fetch(`${API}?q=${buscar}&orden=${ordenActual}`);
    const articulos = await res.json();

    const tabla = document.getElementById("tabla");
    tabla.innerHTML = "";

    articulos.forEach(a => {
        tabla.innerHTML += `
            <tr>
                <td><img src="http://localhost:5120${a.imagen}" class="miniatura"></td>
                <td>${a.nombre}</td>
                <td>${a.stock}</td>
                <td>${a.precio.toFixed(2)} €</td>
                <td>
                    <button onclick="editar(${a.id})">Editar</button>
                    <button onclick="eliminar(${a.id})">Eliminar</button>
                </td>
            </tr>
        `;
    });
}

function buscar() {
    cargarArticulos();
}

function ordenar(tipo) {
    ordenActual = tipo;
    cargarArticulos();
}

function nuevo() {
    window.location.href = "formulario.html";
}

function editar(id) {
    window.location.href = `formulario.html?id=${id}`;
}

async function eliminar(id) {
    if (!confirm("¿Seguro que quieres eliminar este artículo?")) return;

    await fetch(`${API}/${id}`, { method: "DELETE" });
    cargarArticulos();
}

cargarArticulos();
