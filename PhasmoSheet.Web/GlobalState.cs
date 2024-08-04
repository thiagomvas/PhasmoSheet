using System.Collections.Generic;
using System.ComponentModel;
using MudBlazor;
using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Web
{
    public class GlobalState : INotifyPropertyChanged
    {
        private List<Evidence> _confirmedEvidences = new List<Evidence>();
        private List<Evidence> _ruledOutEvidences = new List<Evidence>();

        public List<Evidence> ConfirmedEvidences
        {
            get => _confirmedEvidences;
            set
            {
                _confirmedEvidences = value;
                OnPropertyChanged(nameof(ConfirmedEvidences));
            }
        }

        public List<Evidence> RuledOutEvidences
        {
            get => _ruledOutEvidences;
            set
            {
                _ruledOutEvidences = value;
                OnPropertyChanged(nameof(RuledOutEvidences));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string GetEvidenceIconButton(Evidence evidence)
        {
            if (ConfirmedEvidences.Contains(evidence))
            {
                return Icons.Material.Filled.Check;
            }
            else if (RuledOutEvidences.Contains(evidence))
            {
                return Icons.Material.Filled.Close;
            }
            else
            {
                return Icons.Material.Filled.QuestionMark;
            }
        }

        public Color GetEvidenceButtonColor(Evidence evidence)
        {
            if (ConfirmedEvidences.Contains(evidence))
            {
                return Color.Success;
            }
            else if (RuledOutEvidences.Contains(evidence))
            {
                return Color.Error;
            }
            else
            {
                return Color.Default;
            }
        }

        public void ToggleEvidence(Evidence evidence)
        {
            if (ConfirmedEvidences.Contains(evidence))
            {
                ConfirmedEvidences.Remove(evidence);
                RuledOutEvidences.Add(evidence);
            }
            else if (RuledOutEvidences.Contains(evidence))
            {
                RuledOutEvidences.Remove(evidence);
            }
            else
            {
                ConfirmedEvidences.Add(evidence);
            }
            OnPropertyChanged(nameof(ConfirmedEvidences));
            OnPropertyChanged(nameof(RuledOutEvidences));
        }

        public void Reset()
        {
            ConfirmedEvidences.Clear();
            RuledOutEvidences.Clear();
            OnPropertyChanged(nameof(ConfirmedEvidences));
            OnPropertyChanged(nameof(RuledOutEvidences));
        }
    }
}
