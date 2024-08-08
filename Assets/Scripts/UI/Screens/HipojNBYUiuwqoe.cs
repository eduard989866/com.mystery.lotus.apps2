using GYpqoiwheui;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace FTyuikqlwe.odjhuqwopoe
{
    public class HipojNBYUiuwqoe : BasCreen
    {
        [FormerlySerializedAs("levelButtons")] [SerializeField] private Button[] qlkjdiubqwope;
        [FormerlySerializedAs("profileName")] [SerializeField] private Text kjhfduweior;
        [FormerlySerializedAs("profilePhoto")] [SerializeField] private Image osjdoewroi;
        [FormerlySerializedAs("photoMask")] [SerializeField] private RectTransform wepoqwekop;
        
        private LvfeqxWwsq _lvfeqxWwsq;
        private UsewcFwqeVver _usewcFwqeVver;

        private void Start()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            for (int i = 0; i < qlkjdiubqwope.Length; ++i)
            {
                var t = i;
                qlkjdiubqwope[i].onClick.AddListener(() => HGYVIwuoepqpw(t));
            }
        }

        public void POHgwvyejqwpe(
            LvfeqxWwsq lvfeqxWwsq, 
            UsewcFwqeVver usewcFwqeVver
        )
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            _lvfeqxWwsq = lvfeqxWwsq;
            _usewcFwqeVver = usewcFwqeVver;
            
            IHUBwoiedqwjjpoei();
        }
        
        public void HGYVIwuoepqpw(int levelIndex)
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            VolMangr.NHGUIdoqwe();
            _cvfw.ChdeDeqv<Jhubhqjwkqwe, OGbdqpwoek>(new OGbdqpwoek { qwihegbijver = levelIndex });
        }
        
        public override void MJIOnqwpeHUO()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            kjhfduweior.text = PlayerPrefs.HasKey(NBUioqwheIP.OOIHgwyqiue) 
                ? PlayerPrefs.GetString(NBUioqwheIP.OOIHgwyqiue) 
                : "Name";
            osjdoewroi.sprite = _usewcFwqeVver.NuihHUIhqwe;
            osjdoewroi.SetNativeSize();
            
            var qwoehgqywviui = wepoqwekop.rect.height / osjdoewroi.rectTransform.rect.height / 
                                osjdoewroi.transform.localScale.y;
            var fjvierewpr = wepoqwekop.rect.width / osjdoewroi.rectTransform.rect.width
                                                       / osjdoewroi.transform.localScale.x;

            if (qwoehgqywviui < .9 && fjvierewpr < .9) 
                osjdoewroi.transform.localScale *= Mathf.Max(qwoehgqywviui, fjvierewpr);
            
            osjdoewroi.color = new Color(255, 255, 255, osjdoewroi.sprite is null ? 0 : 255);
            
            IHUBwoiedqwjjpoei();
            
            base.MJIOnqwpeHUO();
        }
        
        private void IHUBwoiedqwjjpoei()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            for (int i = 0; i < qlkjdiubqwope.Length; ++i)
            {
                qlkjdiubqwope[i].interactable = i <= _lvfeqxWwsq.JIOjHUIhhOI;
            }
        }
    }
}