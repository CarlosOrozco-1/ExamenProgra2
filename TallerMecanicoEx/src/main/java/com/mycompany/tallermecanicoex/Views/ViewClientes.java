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
import javax.swing.table.DefaultTableModel;
import java.awt.*;

public class ViewClientes extends JFrame {
    private JButton btnVolver;
    private JTable tablaClientes;
    private DefaultTableModel modelo;

    public ViewClientes() {
        setTitle("Clientes - Taller El Veloz");
        setSize(800, 400);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setLocationRelativeTo(null);
        setLayout(new BorderLayout());

        modelo = new DefaultTableModel(new String[]{"ID", "Nombre", "Apellido", "Teléfono", "Email"}, 0);
        tablaClientes = new JTable(modelo);
        JScrollPane scrollPane = new JScrollPane(tablaClientes);
        add(scrollPane, BorderLayout.CENTER);

        JPanel panelBotones = new JPanel(new FlowLayout(FlowLayout.CENTER, 15, 10));
        btnVolver = new JButton("Menú");
        btnVolver.setPreferredSize(new Dimension(120, 30));
        panelBotones.add(btnVolver);
        add(panelBotones, BorderLayout.SOUTH);

        btnVolver.addActionListener(e -> {
            dispose();
            new Menu().setVisible(true);
        });
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> new ViewClientes().setVisible(true));
    }
}



