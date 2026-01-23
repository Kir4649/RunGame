using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

namespace beatfall
{
//    public class HitLineJudge : MonoBehaviour
//    {
//        public enum JUDGE_STATE
//        {
//            none = 0,
//            PERFECT,
//            GREAT,
//            GOOD,
//            BAD
//        }
//        [Header("Reference")]
//        public MusicConductor conductor;
//        [Header("Lane Keys (0Å`3)")]
//        public KeyCode[] laneKeys = new KeyCode[4]
//        {
//            KeyCode.D,
//            KeyCode.F,
//            KeyCode.J,
//            KeyCode.K,
//        };
//        [Header("îªíËÉEÉBÉhÉE(ïb)")]
//        public float perfectWindow = 0.04f;
//        public float greatWindow = 0.04f;
//        public float goodWindow = 0.04f;
//        public int[] point = new int[5]
//        {
//            0, 100, 50, 20, 0
//        };
//        Line<NotMover>[] laneNotes;
//        public int score = 0;
//        public int combo = 0;

//        private void Awake()
//        {
//            //laneNotes = new Line<NotMover>[4];
//            for (int i = 0; i < laneNotes.Length; i++)
//            {
//                //laneNotes[i] = new Line<NotMover>();
//            }
//            if (conductor == null)
//            {
//                return;
//            }
//        }
//        private void Update()
//        {
//            if (conductor == null)
//            {
//                return;
//            }
//            if (conductor.audioSource.isPlaying)
//            {
//                return;
//            }
//        }
//        float songTime = conductor.SongTime;

//        for(int lane = 0; lane<laneKeys.Length && lane<laneNotes.Length; lane++)
//        {
//            if(Input.GetKeyDown(laneKeys[lane]))
//            {
//             TryHitLane(lane, songTime);
//    }
//}

//void TryHitLane(int lane, float songTime)
//{
//    var list = laneNotes[lane];
//    if (list.Count == 0)
//    {
//        return;
//    }
//    NoteMover best = null;
//    float bestDiff = float.MaxValue;
//    foreach (var n in list)
//    {
//        if (n == null)
//        {
//            continue;
//        }
//        float diff = Mathf.Abs(n.HitTime - songTime);
//        if (diff < bestDiff)
//        {
//            bestDiff = diff;
//            best = n;
//        }

//    }
//    if (best == null)
//    {
//        return;
//    }
//    JUDGE_STATE juge;
//    if (bestDiff <= perfectWindow)
//    {
//        juge = JUDGE_STATE.PERFECT;
//    }
//    else if (bestDiff <= greatWindow)
//    {
//        juge = JUDGE_STATE.GREAT;
//    }
//    else if (bestDiff <= goodWindow)
//    {
//        juge = JUDGE_STATE.GOOD;
//    }
//    else
//    {
//        juge = JUDGE_STATE.BAD;
//        combo = 0;
//        return;
//    }
//    list.Remove(best);
//    Destroy(best.gameObject);

//    combo++;
//    score += point[(int)juge] * combo;

//}
//private void OnTriggerEnter(Collider other)
//{
//    var note = other.GetComponent<NoteMover>();
//    if (note == null)
//    {
//        return;
//    }
//    int note = note.lane;
//    if (lane < 0 || lane >= laneNotes.Length)
//    {
//        return;
//    }
//    if (!laneNotes[lane].Contains(note))
//    {
//        laneNotes[lane].Add(note);
//    }
//}
//private void OnTriggerExit(Collider other)
//{
//    var note = other.GetComponent<NoteMover>();
//    if (note = null)
//    {
//        return;
//    }
//    int lane = note.lane;
//    if (lane < 0 || lane >= laneNotes.Length)
//    {
//        return;
//    }
//    laneNotes[lane].Remove(note);
//}

//public void OnHitButton(int _lane)
//{
//    if (conductor == null)
//    {
//        return;
//    }
//    float songTime  conductor.songTime;
//    TryHitLane(_lane, songTime);
//}
//    }

}


