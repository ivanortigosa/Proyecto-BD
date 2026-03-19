const API = "http://localhost:5120/api/articulos";

const params = new URLSearchParams(window.location.search);
const id = params.get("id");

const titulo = document.getElementById("titulo");
const inputId = document.getElementById("id");
const nombre = document.getElementById("nombre");
const imagen = document.getElementById("imagen");
const imagenActual = document.getElementById("imagenActual");
const stock = document.getElementById("stock");
const precio = document.getElementById("precio");

titulo.textContent = id ? "Editar artículo" : "Nuevo artículo";

if (id) cargarArticulo();

async function cargarArticulo() {
    const res = await fetch(`${API}/${id}`);
    const a = await res.json();

    inputId.value = a.id;
    nombre.value = a.nombre;
    stock.value = a.stock;
    precio.value = a.precio;

    // Guardamos la ruta actual por si no se sube una nueva imagen
    imagenActual.value = a.imagen;
}

document.getElementById("form").addEventListener("submit", async e => {
    e.preventDefault();

    const formData = new FormData();
    formData.append("nombre", nombre.value);
    formData.append("stock", stock.value);
    formData.append("precio", precio.value);

    if (imagen.files.length > 0) {
        formData.append("imagen", imagen.files[0]);
    } else {
        formData.append("imagenActual", imagenActual.value);
    }

    const metodo = id ? "PUT" : "POST";
    const url = id ? `${API}/${id}` : API;

    await fetch(url, {
        method: metodo,
        body: formData
    });

    volver();
});

function volver() {
    window.location.href = "index.html";
}
