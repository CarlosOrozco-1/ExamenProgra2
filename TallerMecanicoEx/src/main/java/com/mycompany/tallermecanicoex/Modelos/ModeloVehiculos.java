/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.tallermecanicoex.Modelos;

/**
 *
 * @author Carlos Orozco
 */
public class ModeloVehiculos {
    
    
    private int idVehiculo;
    private String marca;
    private String modelo;
    private int anio;
    private String patente;
    
    public ModeloVehiculos(){}

    // Getters y setters
    
    public int getId() { return idVehiculo; }
    public void setId(int id) { this.idVehiculo = idVehiculo; }
    public String getMarca() { return marca; }
    public void setMarca(String marca) { this.marca = marca; }
    public String getModelo() { return modelo; }
    public void setModelo(String modelo) { this.modelo = modelo; }
    public int getAnio() { return anio; }
    public void setAnio(int anio) { this.anio = anio; }
    public String getPatente() { return patente; }
    public void setPatente(int anio) { this.patente = patente; }
    }


