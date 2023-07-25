/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ec.edu.kgarcia.prueba;

import ec.edu.kgarcia.servico.EurekaService;

/**
 *
 * @author garci
 */
public class Prueba2 {
    public static void main(String[] args){
        try{
            String cuenta="00100001";
            double importe=200;
            String codEmp="0001";
            EurekaService service=new EurekaService();
            service.regDeposito(cuenta, importe);
            System.out.println("Proceso ok");
        }catch(Exception e){
            e.printStackTrace();
        }
    }

}
