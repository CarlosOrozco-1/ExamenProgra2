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

public class ViewMecanicos extends JFrame {
    private JButton btnVolver;
    private JTable tablaMecanicos;
    private DefaultTableModel modelo;

    public ViewMecanicos() {
        setTitle("Mecánicos - Taller El Veloz");
        setSize(800, 400);
        setDefaultCloseOperation(DISPOSE_ON_CLOSE);
        setLocationRelativeTo(null);
        setLayout(new BorderLayout());

        modelo = new DefaultTableModel(new String[]{"ID", "Nombre", "Especialidad", "Teléfono"}, 0);
        tablaMecanicos = new JTable(modelo);
        JScrollPane scrollPane = new JScrollPane(tablaMecanicos);
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
        SwingUtilities.invokeLater(() -> new ViewMecanicos().setVisible(true));
    }
}
