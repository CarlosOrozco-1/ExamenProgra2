package com.mycompany.tallermecanicoex.Views;

import com.mycompany.tallermecanicoex.Modelos.ModeloVehiculos;
import com.mycompany.tallermecanicoex.Servicios.ServicioVehiculos;
import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.awt.*;
import java.awt.event.*;
import java.util.List;

public class ViewVehiculos extends JFrame {

    private JTable tablaVehiculos;
    private JButton btnMenu;

    public ViewVehiculos() {
        setTitle("Gestión de Vehículos");
        setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
        setSize(800, 500);
        setLocationRelativeTo(null);
        setLayout(new BorderLayout());

        // Panel de botones
        JPanel panelBotones = new JPanel();
        panelBotones.setLayout(new FlowLayout(FlowLayout.CENTER, 10, 10));

        btnMenu = new JButton("Volver al Menú Principal");
        btnMenu.setPreferredSize(new Dimension(200, 30));
        panelBotones.add(btnMenu);

        // Evento botón menú
        btnMenu.addActionListener(e -> {
            dispose();
            new Menu().setVisible(true);
        });

        // Tabla
        tablaVehiculos = new JTable();
        tablaVehiculos.setModel(new DefaultTableModel(
                new Object[][]{},
                new String[]{"IdVehiculo", "Marca", "Modelo", "Año", "Placa", "Patente"}
        ));

        JScrollPane scrollPane = new JScrollPane(tablaVehiculos);

        // Agregar componentes
        add(panelBotones, BorderLayout.NORTH);
        add(scrollPane, BorderLayout.CENTER);

        // Cargar datos
        cargarDatosEnTabla();
    }

    private void cargarDatosEnTabla() {
        try {
            List<ModeloVehiculos> lista = new ServicioVehiculos().obtenerVehiculos();
            DefaultTableModel model = (DefaultTableModel) tablaVehiculos.getModel();
            model.setRowCount(0); // Limpiar

            for (ModeloVehiculos v : lista) {
                model.addRow(new Object[]{
                    v.getId(),
                    v.getMarca(),
                    v.getModelo(),
                    v.getAnio(),
                    v.getPatente()

                }
                );
            }

        } catch (Exception e) {
            JOptionPane.showMessageDialog(this, "Error al cargar datos: " + e.getMessage());
            e.printStackTrace();
        }
    }

// Método main para pruebas
    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            new ViewVehiculos().setVisible(true);
        });
    }
}
