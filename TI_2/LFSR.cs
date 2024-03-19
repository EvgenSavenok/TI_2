using System.Collections.Generic;
using System.Text;
using System;

namespace TI_2
{
    public class LFSR
    {
        private List<int> _polynomous;
        private List<List<int>> _bitsList;
        private StringBuilder _registerState;
        public LFSR(List<int> polynomous, string startRegisterState, List<List<int>> bitsList)
        {
            _polynomous = polynomous;
            _registerState = new StringBuilder(startRegisterState);
            _bitsList = bitsList;
        }

        public string StartLFSR()
        {
            for (int i = 0; i < _bitsList.Count; i++)
            {
                bool xorResult = false;
                foreach (int index in _polynomous)
                {
                    bool bit1 = _registerState[Math.Abs(index - 2 - _registerState.Length)] == '1';
                    bool bit2 = _registerState[Math.Abs(index - 1 - _registerState.Length)] == '1';
                    xorResult = bit1 ^ bit2;
                }
                _registerState.Insert(0, xorResult ? '1' : '0');
                _registerState.Remove(_registerState.Length - 1, 1);
            }
            return _registerState.ToString();
        }
    }
}