using System;
using System.Collections.Generic;

namespace Wpf_Diary
{
    public class Note
    {
        public DateTime Date_note;
        public string Name { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public static List<Note> notes = new List<Note>();

        public static void Notes()
        {
            Note note1 = new();
            note1.Date_note = new DateTime(2023, 03, 03);
            note1.Name = "Сходить на пары";
            note1.Text = "10.10-11.40 2 Основы алгоритмизации и программирования\tИ.Д. Буканов\r\n" +
                "12.00-13.30 3 Основы алгоритмизации и программирования\tИ.Д. Буканов\r\n" +
                "14.00-15.30 4 Архитектура аппаратных средств\tД.В. Мысев\r\n" +
                "15.40-17.10 5 Физическая культура\tВ.В. Григорьев\r\n";

            notes.Add(note1);

            Note note2 = new();
            note2.Date_note = new DateTime(2023, 03, 02);
            note2.Name = "Позвонить маме";
            note2.Text = "Обещал позвонить";

            notes.Add(note2);

            Note note3 = new();
            note3.Date_note = new DateTime(2023, 03, 02);
            note3.Name = "Сходить на пары";
            note3.Text = "08.30-10.00 1 Основы философии\tВ.О. Никишин\r\n" +
                "10.10-11.40 2 Компьютерные сети\tК.А. Дзюба\r\n" +
                "12.00-13.30 3 Информационные технологии\tА.Г. Молодцова\r\n" +
                "14.00-15.30 4 Дискретная математика с элементами математической логики\tК.В. Мотыльков\r\n";

            notes.Add(note3);

            Note note4 = new();
            note4.Date_note = new DateTime(2023, 03, 04);
            note4.Name = "Съездить к сестре";
            note4.Text = "Отвезти пакет";

            notes.Add(note4);

            Note note5 = new();
            note5.Date_note = new DateTime(2023, 03, 04);
            note5.Name = "Сходить на пары";
            note5.Text = "08.30-10.00 1 Элементы высшей математики\tМ.В. Черемных\r\n" +
                "10.10-11.40 2 Информационные технологии\tА.Г. Молодцова\r\n" +
                "12.00-13.30 3 Основы алгоритмизации и программирования\tС.А. Скорогудаева\r\n";

            notes.Add(note5);
        }

        public static void Create_note(DateTime Date_note, string Name, string Text)
        {
            Note new_note = new();
            new_note.Date_note = Date_note;
            new_note.Name = Name;
            new_note.Text = Text;

            notes.Add(new_note);
        }

        public static void Update_note(int? note_index, DateTime Date_note, string Name, string Text)
        {
            Note updated_note= new();
            updated_note.Date_note = Date_note;
            updated_note.Name = Name;
            updated_note.Text = Text;

            notes[Convert.ToInt32(note_index)] = updated_note;
        }
    }
}
