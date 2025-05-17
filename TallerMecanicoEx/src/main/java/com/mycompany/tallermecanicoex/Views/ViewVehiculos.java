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
import java.awt.event.*;

public class ViewVehiculos extends JFrame {

     private JTable tablaVehiculos;
    private DefaultTableModel modeloTabla;
    private JTextField txtId, txtMarca, txtModelo, txtAnio;
    private JButton btnAgregar, btnActualizar, btnEliminar, btnVolver;

    public ViewVehiculos() {
        setTitle("Gestión de Vehículos");
        setSize(600, 450);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);

        setLayout(new BorderLayout(10, 10));

        // Panel formulario (arriba)
        JPanel panelForm = new JPanel(new GridLayout(5, 2, 10, 10));
        panelForm.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));

        panelForm.add(new JLabel("ID:"));
        txtId = new JTextField();
        panelForm.add(txtId);

        panelForm.add(new JLabel("Marca:"));
        txtMarca = new JTextField();
        panelForm.add(txtMarca);

        panelForm.add(new JLabel("Modelo:"));
        txtModelo = new JTextField();
        panelForm.add(txtModelo);

        panelForm.add(new JLabel("Año:"));
        txtAnio = new JTextField();
        panelForm.add(txtAnio);

        // Panel botones formulario
        JPanel panelBotones = new JPanel(new FlowLayout(FlowLayout.LEFT));
        btnAgregar = new JButton("Agregar");
        btnActualizar = new JButton("Actualizar");
        btnEliminar = new JButton("Eliminar");
        btnVolver = new JButton("Volver al Menú");

        panelBotones.add(btnAgregar);
        panelBotones.add(btnActualizar);
        panelBotones.add(btnEliminar);
        panelBotones.add(btnVolver);

        // Contenedor arriba: formulario + botones
        JPanel panelArriba = new JPanel(new BorderLayout());
        panelArriba.add(panelForm, BorderLayout.CENTER);
        panelArriba.add(panelBotones, BorderLayout.SOUTH);

        add(panelArriba, BorderLayout.NORTH);

        // Tabla (abajo)
        modeloTabla = new DefaultTableModel(new Object[]{"ID", "Marca", "Modelo", "Año"}, 0);
        tablaVehiculos = new JTable(modeloTabla);
        JScrollPane scrollPane = new JScrollPane(tablaVehiculos);
        add(scrollPane, BorderLayout.CENTER);

        // Eventos botones
        btnAgregar.addActionListener(e -> agregarVehiculo());
        btnActualizar.addActionListener(e -> actualizarVehiculo());
        btnEliminar.addActionListener(e -> eliminarVehiculo());
        btnVolver.addActionListener(e -> volverAlMenu());

        // Cargar datos en formulario al seleccionar fila
        tablaVehiculos.getSelectionModel().addListSelectionListener(e -> {
            if (!e.getValueIsAdjusting() && tablaVehiculos.getSelectedRow() != -1) {
                int fila = tablaVehiculos.getSelectedRow();
                txtId.setText(modeloTabla.getValueAt(fila, 0).toString());
                txtMarca.setText(modeloTabla.getValueAt(fila, 1).toString());
                txtModelo.setText(modeloTabla.getValueAt(fila, 2).toString());
                txtAnio.setText(modeloTabla.getValueAt(fila, 3).toString());
            }
        });
    }

    private void agregarVehiculo() {
        String id = txtId.getText().trim();
        String marca = txtMarca.getText().trim();
        String modelo = txtModelo.getText().trim();
        String anio = txtAnio.getText().trim();

        if (id.isEmpty() || marca.isEmpty() || modelo.isEmpty() || anio.isEmpty()) {
            JOptionPane.showMessageDialog(this, "Por favor, complete todos los campos.");
            return;
        }

        modeloTabla.addRow(new Object[]{id, marca, modelo, anio});
        limpiarCampos();
    }

    private void actualizarVehiculo() {
        int fila = tablaVehiculos.getSelectedRow();
        if (fila == -1) {
            JOptionPane.showMessageDialog(this, "Seleccione un vehículo para actualizar.");
            return;
        }

        modeloTabla.setValueAt(txtId.getText(), fila, 0);
        modeloTabla.setValueAt(txtMarca.getText(), fila, 1);
        modeloTabla.setValueAt(txtModelo.getText(), fila, 2);
        modeloTabla.setValueAt(txtAnio.getText(), fila, 3);
        limpiarCampos();
    }

    private void eliminarVehiculo() {
        int fila = tablaVehiculos.getSelectedRow();
        if (fila == -1) {
            JOptionPane.showMessageDialog(this, "Seleccione un vehículo para eliminar.");
            return;
        }

        modeloTabla.removeRow(fila);
        limpiarCampos();
    }

    private void limpiarCampos() {
        txtId.setText("");
        txtMarca.setText("");
        txtModelo.setText("");
        txtAnio.setText("");
        tablaVehiculos.clearSelection();
    }

    private void volverAlMenu() {
        this.dispose();          // Cierra esta ventana
        SwingUtilities.invokeLater(() -> {
            Menu menu = new Menu();
            menu.setVisible(true);
        });
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            ViewVehiculos form = new ViewVehiculos();
            form.setVisible(true);
        });
    }
}