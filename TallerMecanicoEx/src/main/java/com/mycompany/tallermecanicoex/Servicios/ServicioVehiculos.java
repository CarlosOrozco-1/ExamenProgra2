/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.tallermecanicoex.Servicios;

/**
 *
 * @author Carlos Orozco
 */



import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;

import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.InputStreamReader;
import java.lang.reflect.Type;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.List;
import com.mycompany.tallermecanicoex.Modelos.ModeloVehiculos;
import com.mycompany.tallermecanicoex.Modelos.ModeloVehiculos;

public class ServicioVehiculos {

    private static final String VEHICULO = "http://localhost:5251/api/Vehiculo";
    private final Gson gson = new Gson();

    public List<ModeloVehiculos> obtenerVehiculos() throws Exception {
        URL url = new URL(VEHICULO);
        HttpURLConnection conn = (HttpURLConnection) url.openConnection();
        conn.setRequestMethod("GET");

        int responseCode = conn.getResponseCode();
        if (responseCode != 200) {
            throw new RuntimeException("Error al obtener vehículos. Código: " + responseCode);
        }

        BufferedReader in = new BufferedReader(new InputStreamReader(conn.getInputStream()));
        StringBuilder response = new StringBuilder();
        String inputLine;

        while ((inputLine = in.readLine()) != null) {
            response.append(inputLine);
        }
        in.close();

        Type listType = new TypeToken<List<ModeloVehiculos>>() {}.getType();
        return gson.fromJson(response.toString(), listType);
    }
}


