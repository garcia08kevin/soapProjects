/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ec.edu.kgarcia.prueba;

import ec.edu.kgarcia.db.AccesoDB;
import java.sql.Connection;

/**
 *
 * @author garci
 */
public class PruebaConexionBD {
        public static void main(String[] args) {
        try {
            Connection cn = AccesoDB.getConnection();
            System.out.println("OK");
            cn.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    } 
}
