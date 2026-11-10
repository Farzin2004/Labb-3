using Labb_3.Models;
using QuizConfigurator.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Labb_3.ViewModels
{
    internal class QuestionPackViewModel : ViewModelBase
    {
        private readonly QuestionPack _model;

        public QuestionPackViewModel (QuestionPack models)
        {
            _model = models;
            Questions = new ObservableCollection<Question>(_model.Questions);
        }
        public string Name
        {
            get => _model.Name;
            set
            {
                if (_model.Name == value)
                    return;
                _model.Name = value;
                RaisePropertyChanged();
            }
        }
        public int TimeLimitInSeconds
        {
            get => _model.TimeLimitInSeconds;
            set
            {
                if (_model.TimeLimitInSeconds == value)
                    return;
                _model.TimeLimitInSeconds = value;
                RaisePropertyChanged();
            }
        }
        public Difficulty Difficulty
        {
            get => _model.Difficulty;
            set
            {
                if (_model.Difficulty == value)
                    return;
                _model.Difficulty = value;
                RaisePropertyChanged();
            }
        }





        public ObservableCollection<Question> Questions { get; }

        public Difficulty[] Difficulties { get; } = Enum.GetValues<Difficulty>();
        public QuestionPack GetModel()
        {
            _model.Questions = Questions.ToList();
            return _model;
        }

    }
}
