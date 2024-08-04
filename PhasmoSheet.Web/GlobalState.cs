using System.Collections.Generic;
using System.ComponentModel;
using MudBlazor;
using PhasmoSheet.Core.Common;
using PhasmoSheet.Core.Ghosts;

namespace PhasmoSheet.Web
{
    public class GlobalState : INotifyPropertyChanged
    {
        private List<Evidence> _confirmedEvidences = new List<Evidence>();
        private List<Evidence> _ruledOutEvidences = new List<Evidence>();
        private List<GhostEvents> _confirmedEvents = new();
        private List<Ghost> correctGhosts = new();
        private List<Ghost> ruledOutGhosts = new();

        private Difficulty _difficulty = Difficulty.Nightmare;

        public bool CanPickMoreEvidence => ConfirmedEvidences.Count < GetMaxEvidencesForDifficulty();
        public Difficulty Difficulty
        {
            get => _difficulty;
            set
            {
                _difficulty = value;
                OnPropertyChanged(nameof(Difficulty));
            }
        }

        public List<Ghost> CorrectGhosts
        {
            get => correctGhosts;
            set
            {
                correctGhosts = value;
                OnPropertyChanged(nameof(CorrectGhosts));
            }
        }

        public List<Ghost> RuledOutGhosts
        {
            get => ruledOutGhosts;
            set
            {
                ruledOutGhosts = value;
                OnPropertyChanged(nameof(RuledOutGhosts));
            }
        }

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

        public List<GhostEvents> ConfirmedEvents
        {
            get => _confirmedEvents;
            set
            {
                _confirmedEvents = value;
                OnPropertyChanged(nameof(ConfirmedEvents));
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
        public string GetGhostEventIconButton(GhostEvents ghostEvent)
        {
            return ConfirmedEvents.Contains(ghostEvent) ? Icons.Material.Filled.Check : Icons.Material.Filled.QuestionMark;
        }
        public Color GetGhostEventButtonColor(GhostEvents ghostEvent)
        {
            return ConfirmedEvents.Contains(ghostEvent) ? Color.Success : Color.Default;
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

        public void ToggleEvent(GhostEvents ghostEvent)
        {
            if (ConfirmedEvents.Contains(ghostEvent))
            {
                ConfirmedEvents.Remove(ghostEvent);
            }
            else
            {
                ConfirmedEvents.Add(ghostEvent);
            }
            OnPropertyChanged(nameof(ConfirmedEvents));
        }

        public void RuleOutGhost(Ghost ghost)
        {
            CorrectGhosts.Remove(ghost);

            if (!RuledOutGhosts.Remove(ghost))
                RuledOutGhosts.Add(ghost);

            OnPropertyChanged(nameof(CorrectGhosts));
        }

        public void ConfirmGhost(Ghost ghost)
        {
            RuledOutGhosts.Remove(ghost);

            if (!CorrectGhosts.Remove(ghost))
                CorrectGhosts.Add(ghost);

            OnPropertyChanged(nameof(RuledOutGhosts));
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
            ConfirmedEvents.Clear();
            CorrectGhosts.Clear();
            RuledOutGhosts.Clear();
            OnPropertyChanged(nameof(ConfirmedEvidences));
            OnPropertyChanged(nameof(RuledOutEvidences));
            OnPropertyChanged(nameof(ConfirmedEvents));
            OnPropertyChanged(nameof(CorrectGhosts));
            OnPropertyChanged(nameof(RuledOutGhosts));
        }

        public int GetMaxEvidencesForDifficulty()
        {
            return Difficulty switch
            {
                Difficulty.Amateur => 3,
                Difficulty.Intermediate => 3,
                Difficulty.Professional => 3,
                Difficulty.Nightmare => 2,
                Difficulty.Insanity => 1,
                Difficulty.ApocalipseIII => 0,
                Difficulty.Custom => 0,
                _ => 3,
            };
        }
    }
}
