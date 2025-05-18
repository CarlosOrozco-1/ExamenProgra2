/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.tallermecanicoex.Views;

/**
 *
 * @author Carlos Orozco
 */
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Menu extends JFrame {

    private JButton btnVehiculos, btnMecanicos, btnServicios, btnClientes,
                    btnTurnos, btnRepuestos, btnFacturas, btnTaller;

    public Menu() {
        setTitle("Taller El Veloz");
        setSize(400, 500);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new BorderLayout());

        // Título
        JLabel titulo = new JLabel("Taller El Veloz", SwingConstants.CENTER);
        titulo.setFont(new Font("Arial", Font.BOLD, 24));
        titulo.setBorder(BorderFactory.createEmptyBorder(20, 0, 20, 0));
        add(titulo, BorderLayout.NORTH);

        // Panel de botones
        JPanel panelBotones = new JPanel(new GridLayout(8, 1, 10, 10));
        panelBotones.setBorder(BorderFactory.createEmptyBorder(10, 40, 10, 40));

        Font fuenteBoton = new Font("Arial", Font.PLAIN, 14);
        Dimension tamanoBoton = new Dimension(150, 30);

        btnVehiculos = crearBoton("Vehículos", fuenteBoton, tamanoBoton);
        btnMecanicos = crearBoton("Mecánicos", fuenteBoton, tamanoBoton);
        btnServicios = crearBoton("Servicios", fuenteBoton, tamanoBoton);
        btnClientes = crearBoton("Clientes", fuenteBoton, tamanoBoton);
        btnTurnos = crearBoton("Turnos", fuenteBoton, tamanoBoton);
        btnRepuestos = crearBoton("Repuestos", fuenteBoton, tamanoBoton);
        btnFacturas = crearBoton("Facturas", fuenteBoton, tamanoBoton);
        btnTaller = crearBoton("Información del Taller", fuenteBoton, tamanoBoton);

        panelBotones.add(btnVehiculos);
        panelBotones.add(btnMecanicos);
        panelBotones.add(btnServicios);
        panelBotones.add(btnClientes);
        panelBotones.add(btnTurnos);
        panelBotones.add(btnRepuestos);
        panelBotones.add(btnFacturas);
        panelBotones.add(btnTaller);

        // Acciones
        btnVehiculos.addActionListener(e -> new ViewVehiculos().setVisible(true));
        btnMecanicos.addActionListener(e -> new ViewMecanicos().setVisible(true));
        btnClientes.addActionListener(e -> new ViewClientes().setVisible(true));
        // Puedes agregar los otros formularios aquí cuando estén listos, por ejemplo:
        // btnMecanicos.addActionListener(e -> new MecanicosForm().setVisible(true));

        // Agregar al centro
        add(panelBotones, BorderLayout.CENTER);
    }

    private JButton crearBoton(String texto, Font fuente, Dimension dimension) {
        JButton boton = new JButton(texto);
        boton.setFont(fuente);
        boton.setPreferredSize(dimension);
        return boton;
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            Menu menu = new Menu();
            menu.setVisible(true);
        });
    }
}
