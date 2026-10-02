using System.Collections.Generic;
namespace backend.EmployeeApi.Data;

public static class EmployeeMockData
{
    public static List<Employee> Employees => new()
    {
        new() { Id = 1, Nombre = "Alejandro García", ProyectoActual = "Talent Unit", ProyectosAnteriores = new(), TiempoEnLaEmpresa = 1 },
        new() { Id = 2, Nombre = "Lucía Fernández", ProyectoActual = "Proyecto Atlas", ProyectosAnteriores = new() { "Proyecto Orion" }, TiempoEnLaEmpresa = 3 },
        new() { Id = 3, Nombre = "Carlos Martínez", ProyectoActual = "Proyecto Nexus", ProyectosAnteriores = new() { "Proyecto Atlas", "Proyecto Horizon" }, TiempoEnLaEmpresa = 5 },
        new() { Id = 4, Nombre = "María López", ProyectoActual = "Proyecto Horizon", ProyectosAnteriores = new() { "Proyecto Genesis" }, TiempoEnLaEmpresa = 2 },
        new() { Id = 5, Nombre = "David Sánchez", ProyectoActual = "Talent Unit", ProyectosAnteriores = new(), TiempoEnLaEmpresa = 1 },
        new() { Id = 6, Nombre = "Paula Romero", ProyectoActual = "Proyecto Orion", ProyectosAnteriores = new() { "Proyecto Atlas" }, TiempoEnLaEmpresa = 4 },
        new() { Id = 7, Nombre = "Javier Torres", ProyectoActual = "Proyecto Phoenix", ProyectosAnteriores = new() { "Proyecto Nexus", "Proyecto Horizon" }, TiempoEnLaEmpresa = 6 },
        new() { Id = 8, Nombre = "Laura Ruiz", ProyectoActual = "Proyecto Genesis", ProyectosAnteriores = new() { "Proyecto Orion" }, TiempoEnLaEmpresa = 3 },
        new() { Id = 9, Nombre = "Sergio Navarro", ProyectoActual = "Proyecto Atlas", ProyectosAnteriores = new() { "Proyecto Phoenix" }, TiempoEnLaEmpresa = 5 },
        new() { Id = 10, Nombre = "Cristina Gil", ProyectoActual = "Talent Unit", ProyectosAnteriores = new(), TiempoEnLaEmpresa = 2 },

        new() { Id = 11, Nombre = "Miguel Ortega", ProyectoActual = "Proyecto Horizon", ProyectosAnteriores = new() { "Proyecto Genesis" }, TiempoEnLaEmpresa = 7 },
        new() { Id = 12, Nombre = "Ana Castillo", ProyectoActual = "Proyecto Nexus", ProyectosAnteriores = new() { "Proyecto Orion" }, TiempoEnLaEmpresa = 4 },
        new() { Id = 13, Nombre = "Raúl Moreno", ProyectoActual = "Proyecto Atlas", ProyectosAnteriores = new() { "Proyecto Horizon", "Proyecto Phoenix" }, TiempoEnLaEmpresa = 8 },
        new() { Id = 14, Nombre = "Silvia Vega", ProyectoActual = "Talent Unit", ProyectosAnteriores = new(), TiempoEnLaEmpresa = 1 },
        new() { Id = 15, Nombre = "Daniel Herrera", ProyectoActual = "Proyecto Phoenix", ProyectosAnteriores = new() { "Proyecto Atlas" }, TiempoEnLaEmpresa = 6 },
        new() { Id = 16, Nombre = "Elena Molina", ProyectoActual = "Proyecto Genesis", ProyectosAnteriores = new() { "Proyecto Nexus" }, TiempoEnLaEmpresa = 5 },
        new() { Id = 17, Nombre = "Rubén Cruz", ProyectoActual = "Proyecto Orion", ProyectosAnteriores = new() { "Proyecto Genesis", "Proyecto Horizon" }, TiempoEnLaEmpresa = 9 },
        new() { Id = 18, Nombre = "Patricia León", ProyectoActual = "Proyecto Atlas", ProyectosAnteriores = new() { "Proyecto Orion" }, TiempoEnLaEmpresa = 3 },
        new() { Id = 19, Nombre = "Álvaro Prieto", ProyectoActual = "Talent Unit", ProyectosAnteriores = new(), TiempoEnLaEmpresa = 2 },
        new() { Id = 20, Nombre = "Marta Cano", ProyectoActual = "Proyecto Nexus", ProyectosAnteriores = new() { "Proyecto Phoenix" }, TiempoEnLaEmpresa = 4 },

        new() { Id = 21, Nombre = "Iván Domínguez", ProyectoActual = "Proyecto Horizon", ProyectosAnteriores = new() { "Proyecto Atlas" }, TiempoEnLaEmpresa = 6 },
        new() { Id = 22, Nombre = "Beatriz Vidal", ProyectoActual = "Proyecto Genesis", ProyectosAnteriores = new() { "Proyecto Nexus" }, TiempoEnLaEmpresa = 5 },
        new() { Id = 23, Nombre = "José Rojas", ProyectoActual = "Talent Unit", ProyectosAnteriores = new(), TiempoEnLaEmpresa = 1 },
        new() { Id = 24, Nombre = "Sara Fuentes", ProyectoActual = "Proyecto Atlas", ProyectosAnteriores = new() { "Proyecto Genesis", "Proyecto Orion" }, TiempoEnLaEmpresa = 7 },
        new() { Id = 25, Nombre = "Adrián Pardo", ProyectoActual = "Proyecto Orion", ProyectosAnteriores = new() { "Proyecto Horizon" }, TiempoEnLaEmpresa = 4 },
        new() { Id = 26, Nombre = "Noelia Ramos", ProyectoActual = "Proyecto Phoenix", ProyectosAnteriores = new() { "Proyecto Atlas" }, TiempoEnLaEmpresa = 3 },
        new() { Id = 27, Nombre = "Hugo Cabrera", ProyectoActual = "Proyecto Nexus", ProyectosAnteriores = new() { "Proyecto Genesis" }, TiempoEnLaEmpresa = 5 },
        new() { Id = 28, Nombre = "Claudia Pastor", ProyectoActual = "Talent Unit", ProyectosAnteriores = new(), TiempoEnLaEmpresa = 2 },
        new() { Id = 29, Nombre = "Víctor Arias", ProyectoActual = "Proyecto Genesis", ProyectosAnteriores = new() { "Proyecto Phoenix", "Proyecto Atlas" }, TiempoEnLaEmpresa = 8 },
        new() { Id = 30, Nombre = "Natalia Soler", ProyectoActual = "Proyecto Horizon", ProyectosAnteriores = new() { "Proyecto Orion" }, TiempoEnLaEmpresa = 6 },

        new() { Id = 31, Nombre = "Lucas Ferrer", ProyectoActual = "Proyecto Atlas", ProyectosAnteriores = new() { "Proyecto Horizon" }, TiempoEnLaEmpresa = 3 },
        new() { Id = 32, Nombre = "Andrea Iglesias", ProyectoActual = "Talent Unit", ProyectosAnteriores = new(), TiempoEnLaEmpresa = 1 },
        new() { Id = 33, Nombre = "Óscar Peña", ProyectoActual = "Proyecto Phoenix", ProyectosAnteriores = new() { "Proyecto Genesis", "Proyecto Orion" }, TiempoEnLaEmpresa = 7 },
        new() { Id = 34, Nombre = "Julia Costa", ProyectoActual = "Proyecto Nexus", ProyectosAnteriores = new() { "Proyecto Atlas" }, TiempoEnLaEmpresa = 4 },
        new() { Id = 35, Nombre = "Eric Delgado", ProyectoActual = "Proyecto Horizon", ProyectosAnteriores = new() { "Proyecto Phoenix" }, TiempoEnLaEmpresa = 6 },
        new() { Id = 36, Nombre = "Carla Marín", ProyectoActual = "Talent Unit", ProyectosAnteriores = new(), TiempoEnLaEmpresa = 2 },
        new() { Id = 37, Nombre = "Pablo Guerrero", ProyectoActual = "Proyecto Orion", ProyectosAnteriores = new() { "Proyecto Genesis" }, TiempoEnLaEmpresa = 5 },
        new() { Id = 38, Nombre = "Alicia Blanco", ProyectoActual = "Proyecto Genesis", ProyectosAnteriores = new() { "Proyecto Atlas", "Proyecto Nexus" }, TiempoEnLaEmpresa = 8 },
        new() { Id = 39, Nombre = "Gonzalo Hidalgo", ProyectoActual = "Proyecto Atlas", ProyectosAnteriores = new() { "Proyecto Orion" }, TiempoEnLaEmpresa = 4 },
        new() { Id = 40, Nombre = "Inés Bravo", ProyectoActual = "Talent Unit", ProyectosAnteriores = new(), TiempoEnLaEmpresa = 1 },
    };
}
