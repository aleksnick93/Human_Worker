﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Human_Worker
{
    class Human_Worker 
    {
        static int numOfWorkers = 0; // Общее количество работников
        String name = null; // Имя
        String surname = null; // Фамилия
        String thirdname = null; // Отчество
        int age = 0; // Возраст
        String phone = null; // Телефонный номер
        String mail = null; // Электронная почта
        int mood = 0;   // Настроение
        int relationship = 0; // Отношение к делу
		int motivation = 0; // Мотивация
		int talent = 0; // Талант
		int skills = 0; // Навыки
        int loyality = 0; // Лояльность компании
        double success = 0; // Показатель успешности
        String kindOfWorker; // Тип работника
		
		public Human_Worker(String name, String surname, String thirdname, int age, String phone, String mail)
        {
            this.name = name;
            this.surname = surname;
            this.thirdname = thirdname;
            this.age = age;
            this.phone = phone;
            this.mail = mail;
            numOfWorkers++;
        }

        public Human_Worker(String name, String surname, String thirdname, String phone, String mail, int age)
        {
            this.name = name;
            this.surname = surname;
            this.thirdname = thirdname;
            this.age = age;
            this.phone = phone;
            this.mail = mail;
            numOfWorkers++;
        }

        public Human_Worker(String name, String surname, String thirdname, String phone, String mail)
        {
            this.name = name;
            this.surname = surname;
            this.thirdname = thirdname;
            this.phone = phone;
            this.mail = mail;
            numOfWorkers++;
        }

        public Human_Worker(String name, String surname, String phone, String mail)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.mail = mail;
            numOfWorkers++;
        }

        public Human_Worker(String name, String surname, int age, String phone)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.phone = phone;
            numOfWorkers++;
        }

        public Human_Worker(String name, String surname, String phone, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.phone = phone;
            numOfWorkers++;
        }

        public Human_Worker(String name, String surname, String phone)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            numOfWorkers++;
        }

        // Сеттеры
        public void setName(String name) { this.name = name; }
        public void setSurname(String surname) { this.surname = surname; }
        public void setThirdname(String thirdname) { this.thirdname = thirdname; }
        public void setAge(int age) { this.age = age; }
        public void setPhone(String phone) { this.phone = phone; }
        public void setMail(String mail) { this.mail = mail; }

        //Геттеры
        public String getName() { return name; }
        public String getSurname() { return surname; }
        public String getThirdname() { return thirdname; }
        public int getAge() { return age; }
        public String getPhone() { return phone; }
        public String getMail() { return mail; }



    }
}
